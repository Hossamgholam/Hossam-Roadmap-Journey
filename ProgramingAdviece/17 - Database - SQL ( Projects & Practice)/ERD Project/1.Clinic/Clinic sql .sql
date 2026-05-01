create database Clinic
use clinic

create table Person(
 UserId int primary key identity(1,1),
 Name nvarchar(50) ,
 Gnder nvarchar(1),
 Email nvarchar(100),
 Phone nvarchar(20),
 address nvarchar(200))

 use Clinic EXEC sp_changedbowner 'sa'
 ---Patient
 create table Patient(
  PatientId int primary key identity(1,1),
  UserId    int Not null,
  constraint Fk_Patient_person foreign key(UserId) references Person(UserId))
 --Doctor    
create table Doctor(
  Doctor_id int primary key identity(1,1),
  specialization nvarchar(100),
  UserId    int Not null,
  constraint Fk_Doctor_person foreign key(UserId) references Person(UserId))
     


create table Appointment(
    AppointmentId int primary key identity(1,1),
    AppointmentDateTime datetime,
    appointmentStatus tinyint,
    PatientId    int Not null,
    Doctor_id    int Not null,
    constraint Fk_Appointment_Patient foreign key(PatientId) references Patient(PatientId),
    constraint Fk_Appointment_Doctort foreign key(Doctor_id) references Doctor(Doctor_id))
     

Create Table Pyment(
    PaymentId int primary key identity(1,1),
    PaymentDate datetime,
    paymentMethod nvarchar(50),
    Amount decimal,
    Notes nvarchar(100),
    AppointmentId    int Not null,
   
    constraint Fk_Pyment_Appointment foreign key(AppointmentId) references Appointment(AppointmentId))
   
   

Create Table MedicalRecords(
    MR_id int primary key identity(1,1),
    [description] nvarchar(50),
    prescribedMedication nvarchar(50),
    Diagnosis int,
    additionalNotes nvarchar(100),
    AppointmentId    int Not null,
   
    constraint Fk_MedicalRecords_Appointment foreign key(AppointmentId) references Appointment(AppointmentId))
     

Create Table Prescription(
    PrescriptionId int primary key identity(1,1),
    MedicationName nvarchar(50),
    Instructions nvarchar(50),
    Dosage nvarchar(50),
    Frequency nvarchar(100),
    StartDate datetime,
    EndDate datetime,
    MR_id    int Not null,
   
    constraint Fk_Prescription_MR_id foreign key(MR_id) references MedicalRecords(MR_id))
     
