FROM flyway/flyway:latest

# Copy your SQL migration scripts
COPY ./sql /flyway/sql

# (Optional) If you have configuration files or placeholders
COPY ./conf/flyway.conf /flyway/conf

# Set the default command to run Flyway
ENTRYPOINT ["flyway", "migrate"]