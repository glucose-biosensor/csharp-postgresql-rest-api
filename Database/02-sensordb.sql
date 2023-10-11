\c sensordb;

-- Insert users

INSERT INTO "Users"("Id", "Username", "Password")
VALUES (1, 'teste', '1234');

-- Insert wavelengths

INSERT INTO "Wavelengths"("Id", "Wavelength", "Color")
VALUES (1, '526', 'green');

INSERT INTO "Wavelengths"("Id", "Wavelength", "Color")
VALUES (2, '660', 'red');

INSERT INTO "Wavelengths"("Id", "Wavelength", "Color")
VALUES (3, '950', 'infrared');

-- Insert sensor data

-- green

INSERT INTO "SensorData"("Id", "Timestamp", "Data", "IdUser", "IdWavelength")
VALUES (1, '4552265', '2.15', 1, 1);

INSERT INTO "SensorData"("Id", "Timestamp", "Data", "IdUser", "IdWavelength")
VALUES (2, '4442265', '1.94', 1, 1);

-- red

INSERT INTO "SensorData"("Id", "Timestamp", "Data", "IdUser", "IdWavelength")
VALUES (3, '4262265', '8.52', 1, 2);

INSERT INTO "SensorData"("Id", "Timestamp", "Data", "IdUser", "IdWavelength")
VALUES (4, '4447465', '4.64', 1, 2);

-- infrared

INSERT INTO "SensorData"("Id", "Timestamp", "Data", "IdUser", "IdWavelength")
VALUES (5, '8745655', '6.58', 1, 3);

INSERT INTO "SensorData"("Id", "Timestamp", "Data", "IdUser", "IdWavelength")
VALUES (6, '6244555', '1.45', 1, 3);
