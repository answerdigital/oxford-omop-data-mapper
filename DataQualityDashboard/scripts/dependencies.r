pkgs <- c(
    "DatabaseConnector",
    "remotes"
)

install.packages(pkgs, repos = "http://cran.us.r-project.org", force=TRUE)
remotes::install_github("OHDSI/DataQualityDashboard", repos = "http://cran.us.r-project.org")
