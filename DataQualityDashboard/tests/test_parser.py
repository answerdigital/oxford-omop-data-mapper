import pytest
import json
import os
import tempfile
from typing import Dict

from scripts.parser import (
    load_json,
    extract_metadata,
    filter_failed_checks,
    filter_json,
)


@pytest.fixture
def sample_json_data() -> Dict:
    """
    Fixture providing a sample JSON data structure for testing.
    """
    return {
        "startTimestamp": ["2023-01-01T00:00:00"],
        "endTimestamp": ["2023-01-01T01:00:00"],
        "executionTime": ["1 hour"],
        "executionTimeSeconds": [3600],
        "CheckResults": [
            {
                "passed": 1,
                "notApplicable": 0,
                "checkName": "Successful Check"
            },
            {
                "passed": 0,
                "notApplicable": 0,
                "checkName": "Failed Check 1"
            },
            {
                "passed": 0,
                "notApplicable": 1,
                "checkName": "Not Applicable Check"
            },
            {
                "passed": 0,
                "notApplicable": 0,
                "checkName": "Failed Check 2"
            },
        ]
    }


@pytest.fixture
def temp_json_file(sample_json_data):
    """
    Fixture to create a temporary JSON file with sample data.
    """
    with tempfile.NamedTemporaryFile(
        mode='w',
        delete=False,
        suffix='.json'
    ) as temp_file:

        json.dump(sample_json_data, temp_file)
        temp_file.close()
        yield temp_file.name

    os.unlink(temp_file.name)


def test_load_json(temp_json_file):
    """
    Test that load_json correctly reads a JSON file.
    """
    loaded_data = load_json(temp_json_file)
    assert isinstance(loaded_data, dict)
    assert "CheckResults" in loaded_data


def test_load_json_file_not_found():
    """
    Test that load_json raises FileNotFoundError for non-existent file.
    """
    with pytest.raises(FileNotFoundError):
        load_json("non_existent_file.json")


def test_load_json_invalid_json():
    """
    Test that load_json raises JSONDecodeError for invalid JSON.
    """
    with tempfile.NamedTemporaryFile(
        mode='w',
        delete=False,
        suffix='.json'
    ) as temp_file:

        temp_file.write("Invalid JSON")
        temp_file.close()

        with pytest.raises(json.JSONDecodeError):
            load_json(temp_file.name)

        os.unlink(temp_file.name)


def test_extract_metadata(sample_json_data):
    """
    Test extract_metadata function returns correct metadata.
    """
    metadata = extract_metadata(sample_json_data)

    assert metadata == {
        "startTimestamp": ["2023-01-01T00:00:00"],
        "endTimestamp": ["2023-01-01T01:00:00"],
        "executionTime": ["1 hour"],
        "executionTimeSeconds": [3600]
    }


def test_extract_metadata_missing_fields():
    """
    Test extract_metadata with missing fields returns empty lists.
    """
    empty_data = {}
    metadata = extract_metadata(empty_data)

    assert metadata == {
        "startTimestamp": [],
        "endTimestamp": [],
        "executionTime": [],
        "executionTimeSeconds": []
    }


@pytest.mark.parametrize(
        "expected_output", [
            {
                "Failed Check 1",
                "Failed Check 2"
            }
        ]
    )
def test_filter_failed_checks(sample_json_data, expected_output):
    """
    Test filter_failed_checks correctly filters check results.
    """
    check_results = sample_json_data["CheckResults"]
    failed_checks = filter_failed_checks(check_results)

    assert len(failed_checks) == 2
    assert all(
        check["passed"] == 0 and
        check["notApplicable"] == 0
        for check in failed_checks
    )
    assert {check["checkName"] for check in failed_checks} == expected_output


def test_filter_failed_checks_empty_input():
    """
    Test filter_failed_checks with empty input returns empty list.
    """
    assert filter_failed_checks([]) == []


def test_filter_json(temp_json_file, sample_json_data):
    """
    Test filter_json end-to-end functionality.
    """
    filtered_data = filter_json(temp_json_file)

    # Check metadata preservation
    assert filtered_data["startTimestamp"] == sample_json_data["startTimestamp"] # noqa E501 
    assert filtered_data["endTimestamp"] == sample_json_data["endTimestamp"] # noqa E501 
    assert filtered_data["executionTime"] == sample_json_data["executionTime"] # noqa E501 
    assert filtered_data["executionTimeSeconds"] == sample_json_data["executionTimeSeconds"] # noqa E501 

    # Check failed checks
    assert len(filtered_data["CheckResults"]) == 2
    assert all(
        check["passed"] == 0 and
        check["notApplicable"] == 0
        for check in filtered_data["CheckResults"]
    )


def test_filter_json_no_check_results(sample_json_data):
    """
    Test filter_json with no CheckResults.
    """
    # Create a temporary file without CheckResults
    no_checks_data = {
        k: v for k, v in sample_json_data.items() if k != "CheckResults"
    }

    with tempfile.NamedTemporaryFile(
        mode='w',
        delete=False,
        suffix='.json'
    ) as temp_file:

        json.dump(no_checks_data, temp_file)
        temp_file.close()

        try:
            filtered_data = filter_json(temp_file.name)
            assert filtered_data["CheckResults"] == []
        finally:
            os.unlink(temp_file.name)
