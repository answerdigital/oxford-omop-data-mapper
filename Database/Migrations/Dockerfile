# Use the official Flyway image as base
FROM flyway/flyway:latest

# Set working directory
WORKDIR /flyway

# Create directories for migrations and configuration
RUN mkdir -p /flyway/sql \
    && mkdir -p /flyway/conf

# Copy migration files from your local machine
COPY . .

# Set environment variables (these can be overridden at runtime)
ENV FLYWAY_URL=jdbc:postgresql://db:5432/mydatabase
ENV FLYWAY_USER=postgres
ENV FLYWAY_PASSWORD=password
ENV FLYWAY_LOCATIONS=filesystem:/flyway/sql

# Create volume mount points
VOLUME ["/flyway/sql", "/flyway/conf"]

# Set the default command to run migrations
# This can be overridden at runtime to run other Flyway commands
CMD ["migrate"]