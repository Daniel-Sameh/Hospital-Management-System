use hospital;
/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/7/2024 6:16:47 PM                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Admin') and o.name = 'FK_ADMIN_INHERITAN_EMPLOYEE')
alter table Admin
   drop constraint FK_ADMIN_INHERITAN_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Appointment') and o.name = 'FK_APPOINTM_MAKESAPPO_PATIENT')
alter table Appointment
   drop constraint FK_APPOINTM_MAKESAPPO_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Appointment') and o.name = 'FK_APPOINTM_ASSIGNTO_DOCTOR')
alter table Appointment
   drop constraint FK_APPOINTM_ASSIGNTO_DOCTOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Assists') and o.name = 'FK_ASSISTS_ASSISTS_DOCTOR')
alter table Assists
   drop constraint FK_ASSISTS_ASSISTS_DOCTOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Assists') and o.name = 'FK_ASSISTS_ASSISTS2_NURSE')
alter table Assists
   drop constraint FK_ASSISTS_ASSISTS2_NURSE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Doctor') and o.name = 'FK_DOCTOR_INHERITAN_EMPLOYEE')
alter table Doctor
   drop constraint FK_DOCTOR_INHERITAN_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MedicalRecord') and o.name = 'FK_MEDICALR_HASMEDICA_PATIENT')
alter table MedicalRecord
   drop constraint FK_MEDICALR_HASMEDICA_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Nurse') and o.name = 'FK_NURSE_INHERITAN_EMPLOYEE')
alter table Nurse
   drop constraint FK_NURSE_INHERITAN_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Patient') and o.name = 'FK_PATIENT_ADDS_ADMIN')
alter table Patient
   drop constraint FK_PATIENT_ADDS_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Prescription') and o.name = 'FK_PRESCRIP_CONTAINS_MEDICINE')
alter table Prescription
   drop constraint FK_PRESCRIP_CONTAINS_MEDICINE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Prescription') and o.name = 'FK_PRESCRIP_HAS_PATIENT')
alter table Prescription
   drop constraint FK_PRESCRIP_HAS_PATIENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Prescription') and o.name = 'FK_PRESCRIP_WRITES_DOCTOR')
alter table Prescription
   drop constraint FK_PRESCRIP_WRITES_DOCTOR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Admin')
            and   type = 'U')
   drop table Admin
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Appointment')
            and   name  = 'MakesAppointment_FK'
            and   indid > 0
            and   indid < 255)
   drop index Appointment.MakesAppointment_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Appointment')
            and   name  = 'assignTo_FK'
            and   indid > 0
            and   indid < 255)
   drop index Appointment.assignTo_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Appointment')
            and   type = 'U')
   drop table Appointment
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Assists')
            and   name  = 'Assists2_FK'
            and   indid > 0
            and   indid < 255)
   drop index Assists.Assists2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Assists')
            and   name  = 'Assists_FK'
            and   indid > 0
            and   indid < 255)
   drop index Assists.Assists_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Assists')
            and   type = 'U')
   drop table Assists
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Doctor')
            and   type = 'U')
   drop table Doctor
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Employee')
            and   type = 'U')
   drop table Employee
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MedicalRecord')
            and   name  = 'HasMedicalHistory_FK'
            and   indid > 0
            and   indid < 255)
   drop index MedicalRecord.HasMedicalHistory_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MedicalRecord')
            and   type = 'U')
   drop table MedicalRecord
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Medicine')
            and   type = 'U')
   drop table Medicine
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Nurse')
            and   type = 'U')
   drop table Nurse
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Patient')
            and   name  = 'Adds_FK'
            and   indid > 0
            and   indid < 255)
   drop index Patient.Adds_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Patient')
            and   type = 'U')
   drop table Patient
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Prescription')
            and   name  = 'Contains_FK'
            and   indid > 0
            and   indid < 255)
   drop index Prescription.Contains_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Prescription')
            and   name  = 'Has_FK'
            and   indid > 0
            and   indid < 255)
   drop index Prescription.Has_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Prescription')
            and   name  = 'writes_FK'
            and   indid > 0
            and   indid < 255)
   drop index Prescription.writes_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Prescription')
            and   type = 'U')
   drop table Prescription
go

/*==============================================================*/
/* Table: Admin                                                 */
/*==============================================================*/
create table Admin (
   eId                  numeric(5)           not null,
   constraint PK_ADMIN primary key (eId)
)
go

/*==============================================================*/
/* Table: Appointment                                           */
/*==============================================================*/
create table Appointment (
   apId                 numeric(5)           not null,
   pId                  numeric(5)           not null,
   eId                  numeric(5)           not null,
   type                 varchar(150)         null,
   apPrice              int                  not null,
   apDate               datetime             not null,
   time                 datetime             null,
   patientId            numeric(5)           not null,
   constraint PK_APPOINTMENT primary key (apId)
)
go

/*==============================================================*/
/* Index: assignTo_FK                                           */
/*==============================================================*/




create nonclustered index assignTo_FK on Appointment (eId ASC)
go

/*==============================================================*/
/* Index: MakesAppointment_FK                                   */
/*==============================================================*/




create nonclustered index MakesAppointment_FK on Appointment (pId ASC)
go

/*==============================================================*/
/* Table: Assists                                               */
/*==============================================================*/
create table Assists (
   Doc_eId              numeric(5)           not null,
   eId                  numeric(5)           not null,
   constraint PK_ASSISTS primary key (Doc_eId, eId)
)
go

/*==============================================================*/
/* Index: Assists_FK                                            */
/*==============================================================*/




create nonclustered index Assists_FK on Assists (Doc_eId ASC)
go

/*==============================================================*/
/* Index: Assists2_FK                                           */
/*==============================================================*/




create nonclustered index Assists2_FK on Assists (eId ASC)
go

/*==============================================================*/
/* Table: Doctor                                                */
/*==============================================================*/
create table Doctor (
   eId                  numeric(5)           not null,
   speciality           varchar(250)         not null,
   constraint PK_DOCTOR primary key (eId)
)
go

/*==============================================================*/
/* Table: Employee                                              */
/*==============================================================*/
create table Employee (
   eId                  numeric(5)           not null,
   empFirstName         varchar(100)         not null,
   empLastName          varchar(100)         null,
   empGender            varchar(7)           not null,
   empPhone             numeric(11)          not null,
   empEmail             varchar(150)         not null,
   empPassword          varchar(150)         not null,
   salary               int                  null,
   constraint PK_EMPLOYEE primary key (eId)
)
go

/*==============================================================*/
/* Table: MedicalRecord                                         */
/*==============================================================*/
create table MedicalRecord (
   mId                  numeric(5)           not null,
   pId                  numeric(5)           not null,
   recordDetails        varchar(500)         not null,
   Date                 datetime             null,
   constraint PK_MEDICALRECORD primary key (mId)
)
go

/*==============================================================*/
/* Index: HasMedicalHistory_FK                                  */
/*==============================================================*/




create nonclustered index HasMedicalHistory_FK on MedicalRecord (pId ASC)
go

/*==============================================================*/
/* Table: Medicine                                              */
/*==============================================================*/
create table Medicine (
   medId                numeric(5)           not null,
   Mname                varchar(150)         not null,
   price                int                  not null,
   constraint PK_MEDICINE primary key (medId)
)
go

/*==============================================================*/
/* Table: Nurse                                                 */
/*==============================================================*/
create table Nurse (
   eId                  numeric(5)           not null,
   workHours            int                  null,
   constraint PK_NURSE primary key (eId)
)
go

/*==============================================================*/
/* Table: Patient                                               */
/*==============================================================*/
create table Patient (
   pId                  numeric(5)           not null,
   eId                  numeric(5)           not null,
   firstName            varchar(10)          not null,
   lastName             varchar(10)          null,
   birthDate            datetime             not null,
   pGender              varchar(7)           not null,
   pPhone               numeric(12)          not null,
   pEmail               varchar(150)         not null,
   pPassword            varchar(150)         not null,
   constraint PK_PATIENT primary key (pId)
)
go

/*==============================================================*/
/* Index: Adds_FK                                               */
/*==============================================================*/




create nonclustered index Adds_FK on Patient (eId ASC)
go

/*==============================================================*/
/* Table: Prescription                                          */
/*==============================================================*/
create table Prescription (
   eId                  numeric(5)           not null,
   pId                  numeric(5)           not null,
   medId                numeric(5)           not null,
   presId               numeric(5)           not null,
   pDetails             varchar(500)         null,
   dosage               varchar(150)         null,
   constraint PK_PRESCRIPTION primary key (eId, pId, medId, presId)
)
go

/*==============================================================*/
/* Index: writes_FK                                             */
/*==============================================================*/




create nonclustered index writes_FK on Prescription (eId ASC)
go

/*==============================================================*/
/* Index: Has_FK                                                */
/*==============================================================*/




create nonclustered index Has_FK on Prescription (pId ASC)
go

/*==============================================================*/
/* Index: Contains_FK                                           */
/*==============================================================*/




create nonclustered index Contains_FK on Prescription (medId ASC)
go

alter table Admin
   add constraint FK_ADMIN_INHERITAN_EMPLOYEE foreign key (eId)
      references Employee (eId)
go

alter table Appointment
   add constraint FK_APPOINTM_MAKESAPPO_PATIENT foreign key (pId)
      references Patient (pId)
go

alter table Appointment
   add constraint FK_APPOINTM_ASSIGNTO_DOCTOR foreign key (eId)
      references Doctor (eId)
go

alter table Assists
   add constraint FK_ASSISTS_ASSISTS_DOCTOR foreign key (Doc_eId)
      references Doctor (eId)
go

alter table Assists
   add constraint FK_ASSISTS_ASSISTS2_NURSE foreign key (eId)
      references Nurse (eId)
go

alter table Doctor
   add constraint FK_DOCTOR_INHERITAN_EMPLOYEE foreign key (eId)
      references Employee (eId)
go

alter table MedicalRecord
   add constraint FK_MEDICALR_HASMEDICA_PATIENT foreign key (pId)
      references Patient (pId)
go

alter table Nurse
   add constraint FK_NURSE_INHERITAN_EMPLOYEE foreign key (eId)
      references Employee (eId)
go

alter table Patient
   add constraint FK_PATIENT_ADDS_ADMIN foreign key (eId)
      references Admin (eId)
go

alter table Prescription
   add constraint FK_PRESCRIP_CONTAINS_MEDICINE foreign key (medId)
      references Medicine (medId)
go

alter table Prescription
   add constraint FK_PRESCRIP_HAS_PATIENT foreign key (pId)
      references Patient (pId)
go

alter table Prescription
   add constraint FK_PRESCRIP_WRITES_DOCTOR foreign key (eId)
      references Doctor (eId)
go

