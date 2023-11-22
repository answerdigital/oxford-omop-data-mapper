#!/bin/bash

# Build the Docker image
docker build . --tag omop-flyway

# Run the Docker container
docker run --name flyway omop-flyway

# Remove the Docker image
docker rmi omop-flyway --force