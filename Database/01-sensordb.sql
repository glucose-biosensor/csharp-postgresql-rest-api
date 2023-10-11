CREATE DATABASE sensordb;

\c sensordb;

CREATE TABLE "Users" (
    "Password" VARCHAR(20) NOT NULL,
    "Username" VARCHAR(20) NOT NULL,
    "Id" INT NOT NULL,
    CONSTRAINT "PK_User" PRIMARY KEY ("Id")
);

CREATE TABLE "Wavelengths" (
    "nmWavelength" INT NOT NULL,
    "Color" VARCHAR(20) NOT NULL,
    "Id" INT NOT NULL,
    CONSTRAINT "PK_Wavelength" PRIMARY KEY ("Id")
);

CREATE TABLE "SensorData" (
    "Timestamp" INT NOT NULL,
    "Data" FLOAT NOT NULL,
    "Id" INT NOT NULL,
    "IdUser" INT NOT NULL,
    "IdWavelength" INT NOT NULL,
    CONSTRAINT "PK_SensorData" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_User" FOREIGN KEY ("IdUser") REFERENCES "Users" ("IdUser"),
    CONSTRAINT "FK_Wavelength" FOREIGN KEY ("IdWavelength") REFERENCES "Wavelengths" ("IdWavelength")
);
