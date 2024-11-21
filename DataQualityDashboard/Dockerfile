# Install Ubuntu & R
FROM rocker/verse:latest

# Create a working directory to do stuff from
WORKDIR /etl

# Install Java dependencies
RUN apt-get update && apt-get install -y \
        default-jdk \
        r-cran-rjava \
        nano \
        curl \
        python3-pip \
        lbzip2 \
        cargo \
        apt-utils \
        libudunits2-dev \
        libgdal-dev \
        libproj-dev \
        libpython3-dev \
        python3-tk \
        ffmpeg \
        imagemagick \
    && apt-get clean \
    && rm -rf /var/lib/apt/lists/*

COPY DataQualityDashboard/drivers/ drivers/
COPY DataQualityDashboard/scripts/ .

RUN [ "Rscript", "dependencies.r"]

ENTRYPOINT ["/bin/bash", "-c", "Rscript main.r && python3 parser.py"]