docker run `
    --rm `
    -v ${pwd}/sql:/flyway/sql `
    -v ${pwd}/conf:/flyway/conf `
    flyway/flyway `
    -url=jdbc:"sqlserver://host.docker.internal:1433;databaseName=Omop;encrypt=false" `
    -user=user `
    -password=password `
    migrate migrate