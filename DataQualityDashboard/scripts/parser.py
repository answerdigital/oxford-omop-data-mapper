import json
from typing import List, Dict


def load_json(path: str) -> Dict:
    """
    Load and return JSON data from a file.

    Args:
        path (str): The file path to the JSON file to be
        loaded.

    Returns:
        Dict: The loaded JSON data as a dictionary.
    """
    with open(path, 'r') as file:
        return json.load(file)


def extract_metadata(data: Dict) -> Dict:
    """
    Extract metadata (timestamps, execution time) from the
    loaded JSON data.

    Args:
        data (Dict): The loaded JSON data as a dictionary.

    Returns:
        Dict: A dictionary containing extracted metadata
        like startTimestamp, endTimestamp, executionTime,
        and executionTimeSeconds.
    """
    return {
        "startTimestamp": data.get('startTimestamp', []),
        "endTimestamp": data.get('endTimestamp', []),
        "executionTime": data.get('executionTime', []),
        "executionTimeSeconds": data.get('executionTimeSeconds', [])
    }


def filter_failed_checks(check_results: List[Dict]) -> List[Dict]:
    """
    Filter checks where 'passed' is 0 and 'notApplicable' is 0.

    Args:
        check_results (List[Dict]): A list of check result
        dictionaries to filter.

    Returns:
        List[Dict]: A list of dictionaries where 'passed' is 0
        and 'notApplicable' is 0.
    """
    return [
        check for check in check_results
        if check.get('passed') == 0 and check.get('notApplicable') == 0
    ]


def filter_json(path: str) -> Dict:
    """
    - Load the JSON data from the file
    - Extract the 'CheckResults' list
    - Filter results where 'passed' is 0
    - Prepare the new data structure with the same format

    Args:
        path (str): path to results.json output

    Returns:
        filtered_data (dict): JSON transformed with only failures
    """
    data = load_json(path)
    metadata = extract_metadata(data)
    failed_checks = filter_failed_checks(data.get('CheckResults', []))

    filtered_data = {**metadata, "CheckResults": failed_checks}

    return filtered_data


filtered_data = filter_json(path='output/results.json')

# Save the filtered results to a new file
with open('failed_checks.json', 'w') as output_file:
    json.dump(filtered_data, output_file, indent=4)
