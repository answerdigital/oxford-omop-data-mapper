docker build . --tag omop-flyway
docker run --name flyway omop-flyway
docker rmi omop-flyway --force