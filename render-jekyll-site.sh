#!/bin/bash

# Navigate to the directory of your Jekyll site
# Replace '/path/to/your/site' with the actual path to your Jekyll site directory
#cd /path/to/your/site

# Check if Bundler is installed, install if not
if ! gem spec bundler > /dev/null 2>&1; then
  echo "Bundler is not installed, installing now..."
  gem install bundler
else
  echo "Bundler is already installed."
fi

# Install dependencies specified in the Gemfile
bundle install

# Build the site and make it available on a local server
bundle exec jekyll serve --livereload

# Now you can access your site at http://localhost:4000
