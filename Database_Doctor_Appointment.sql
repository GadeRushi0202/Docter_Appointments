use  Stask

-----------------------------------------
CREATE TABLE Mst_Appointments (
    AppointmentId INT IDENTITY(1,1) PRIMARY KEY,
    PatientName VARCHAR(100) NOT NULL,
    DoctorId INT NOT NULL,
    Description VARCHAR(200),
    AppointmentDate DATE NOT NULL,
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL,
    TotalFees DECIMAL(10,2) NOT NULL,
    PaidFees DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_Doctor FOREIGN KEY (DoctorId) REFERENCES Mst_Doctors(DoctorId)
);

CREATE TABLE mst_Doctors (
    DoctorId INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    FeesPerHour DECIMAL(10,2) NOT NULL,
    MobileNumber VARCHAR(20) NOT NULL,
    Experience INT NOT NULL,
    Speciality VARCHAR(100) NOT NULL,
    Code VARCHAR(20) UNIQUE NOT NULL
);

insert into mst_Doctors values('Rushi',150.00, '7447307393', 10, 'Cardiology', 'D001')
select * from Mst_Appointments
truncate table Mst_Appointments