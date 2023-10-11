# ASP.NET Core 7.0 Web API using C#

## Overview


## Deploy PostgreSQL database

Login on PostgreSQL user account:

```
sudo su - postgres
```

Change the password of the user "postgres":

```
psql
ALTER USER postgres WITH PASSWORD 'postgres@2023';
```

Import SQL script to create database (01-sensordb.sql) and insert test data into tables (02-sensordb.sql)

```
\i /path-to-project-folder/Database/01-sensordb.sql
\i /path-to-project-folder/Database/02-sensordb.sql
```

## Docker Deployment

`sudo apt-get install docker-ce docker-ce-cli containerd.io docker-compose-plugin`

- Deployment with Docker is as simple as executing `docker-compose up` which will setup and deploy both DB and Web API.

## Verification

