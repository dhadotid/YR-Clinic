create database YR

use YR

go
create schema Doctor;
go
create schema Patient;
go
create schema Recipe
go
---------------------------------------------------------------------------------------------------------
/*Table*/

create table AccessLogin(
Id_User varchar(5) primary key,
Username varchar(25) not null,
UPassword varchar(25) not null,
isAdmin int default 0
);

create table Patient.Patient(
Id_Patient	varchar(6) primary key,
Patient_Name	varchar(255) NOT NULL,
DateOfBirth	date not null,
Address	varchar(255) NOT NULL,
GenderPatient	char(10) not null,
);

create table Doctor.Specialist(
Id_Specialist	varchar(6)	primary key,
Specialist	varchar(150) not null,
Fare	varchar(150) not null,
);

create table Doctor.Doctor(
Id_Doctor	varchar(6) primary key,
Id_Specialist	varchar(6) references Doctor.Specialist(Id_Specialist),
DoctorName	varchar(255) not null,
DoctorGender	char(10) not null,
DateOfBirth	date not null,
Phone	varchar(12) not null,
);


create table Recipe.Recipe(
Id_Recipe	varchar(6)	primary key,
Total	Money
);

create table Recipe.Drug(
Id_Drug	varchar(8)	primary key,
DrugName	varchar(150) not null,
DrugType	char(100) not null,
Stock	int not null	check(Stock>=0),
ExpDate	date not null	check(ExpDate>getdate()),
Price	Money not null
);

as @DrugType in ('Capsule','Tablet','Syrup','Cream')

create table Recipe.RecipeDetail(
Id_RecipeDetail	varchar(7)	primary key,
Id_Recipe	varchar(6)	references Recipe.Recipe(Id_Recipe),
Id_Drug	varchar(8) references Recipe.Drug(Id_Drug),
Qty	int not null	check(Qty>0),
Dose	varchar(150) not null,
Subtotal	Money
);

create table Patient.Treatment(
Id_Treatment	varchar(6) primary key,
Id_Patient	varchar(6)	references Patient.Patient(Id_Patient),
Id_Doctor	varchar(6)	references Doctor.Doctor(Id_Doctor),
Id_Recipe	varchar(6)	references Recipe.Recipe(Id_Recipe),
Diagnose	varchar(150)	not null,
DateTreatment	date default getdate(),
);

create table Patient.Payment(
Id_Payment	varchar(8)	primary key,
Id_Treatment	varchar(6)	references	Patient.Treatment(Id_Treatment),
PaymentDoctor	money,
PaymentDrug	money,
TotalPayment	money
);
select * from Patient.Payment
ALTER TABLE Patient.Payment
ALTER COLUMN PaymentDoctor money NULL

ALTER TABLE Patient.Payment
ADD isPay int default 0
select * from AccessLogin
----------------------------------------------------------------------------------------------------------
/*Procedure*/

-- pcd update gk diexecute

create procedure pcdAL
@Username varchar(25),
@UPassword varchar(25),
@isAdmin int
as
begin
	declare @Id_User varchar(5), @Number int
	if exists(select*from AccessLogin)
	begin
		select @Id_User = Id_User from AccessLogin order by Id_User
		set @Number = substring(@Id_User,4,2)
		if @Number between 1 and 8
			set @Id_User = 'USR0' + convert(varchar(6), @Number+1)
		else
		if @Number between 9 and 98
			set @Id_User = 'USR' + convert(varchar(6), @Number+1)
			else
			print 'Data already meets maximum limit'
	end
	else
		set @Id_User = 'USR01'
	begin try
	insert AccessLogin
	values(@Id_User, @Username, @UPassword, @isAdmin)
	if @@rowcount > 0
		print 'Data patient successful inputted'
	else
		print 'Data patient failed inputted'
	end try
	begin catch
		print 'Error : ' + error_message()
	end catch
end

-- Patient
create procedure pcdPatient
@Patient_Name	varchar(255),
@DateOfBirth date,
@Address varchar(255),
@GenderPatient char(10)
as
begin
	declare @Id_Patient varchar(6),  @Number int
	if exists(select*from Patient.Patient)
	begin
		select @Id_Patient = Id_Patient from Patient.Patient order by Id_Patient
		set @Number = substring(@Id_Patient,2,5)
		if @Number between 1 and 8
			set @Id_Patient = 'P0000' + convert(varchar(6), @Number+1)
		else
		if @Number between 9 and 98
			set @Id_Patient = 'P000' + convert(varchar(6), @Number+1)
		else
		if @Number between 99 and 998
			set @Id_Patient = 'P00' + convert(varchar(6), @Number+1)
		else
		if @Number between 999 and 9998
			set @Id_Patient = 'P0' + convert(varchar(6), @Number+1)
		else
		if @Number between 9999 and 99998
			set @Id_Patient = 'P' + convert(varchar(6), @Number+1)
		else
			print 'Data already meets maximum limit'
	end
	else
		set @Id_Patient = 'P00001'
	begin try
	insert Patient.Patient
	values(@Id_Patient, @Patient_Name, @DateOfBirth, @Address, @GenderPatient)
	if @@rowcount > 0
		print 'Data patient successful inputted'
	else
		print 'Data patient failed inputted'
	end try
	begin catch
		print 'Error : ' + error_message()
	end catch
end

create procedure pcddelPatient
@Id_Patient varchar (6)
as
begin
	delete from Patient.Patient where Id_Patient = @Id_Patient
	if @@rowcount > 0
	print 'Data patient successful deleted'
	else
	print 'Data patient failed deleted'
end

create procedure pcduptPatient
@Id_Patient varchar (6),@Patient_Name varchar(255),@DateOfBirth	date,@Address	varchar(255),@GenderPatient	char(10)
as
begin
	update Patient.Patient 
	set Patient_Name = @Patient_Name,DateOfBirth = @DateOfBirth,Address = @Address,GenderPatient = @GenderPatient
	where Id_Patient = @Id_Patient
	if @@rowcount > 0
	print 'Data patient successful updated'
	else
	print 'Data patient failed updated'
end

-- Specialist
create procedure pcdSpecialist
@Specialist	varchar(150),
@Fare	money
as
begin
	declare @Id_Specialist varchar(6), @Number int
	if exists(select*from Doctor.Specialist)
	begin
		select @Id_Specialist = Id_Specialist from Doctor.Specialist order by Id_Specialist
		set @Number = substring(@Id_Specialist,4,3)
		if @Number between 1 and 8
			set @Id_Specialist = 'SPC00' + convert(varchar(6), @Number + 1)
		else
		if @Number between 9 and 98
			set @Id_Specialist = 'SPC0' + convert(varchar(6), @Number + 1)
		else
		if @Number between 99 and 998
			set @Id_Specialist = 'SPC' + convert(varchar(6), @Number + 1)
		else
			print 'Data already meets maximum limit'
	end
	else
		set @Id_Specialist = 'SPC001'

	begin try
	insert Doctor.Specialist
	values (@Id_Specialist, @Specialist,@Fare)
	if @@rowcount > 0
		print 'Data specialist successful inputted'
	else
		print 'Data specialist failed inputted'
	end try
	begin catch
		print 'Error : ' + error_message()
	end catch
end

create procedure pcddelSpecialist
@Id_Specialist	varchar(6)
as
begin
	delete from Doctor.Specialist where @Id_Specialist = Id_Specialist
	if @@rowcount > 0
	print 'Data specialist successful deleted'
	else
	print 'Data specialist failed deleted'
end

create procedure pcduptSpecialist
@Id_Specialist	varchar(6),@Specialist	varchar(150),@Fare money
as
begin
	update Doctor.Specialist 
	set  Specialist =@Specialist, Fare = @Fare
	where @Id_Specialist = Id_Specialist
	if @@rowcount > 0
	print 'Data specialist successful updated'
	else
	print 'Data specialist failed updated'
end

-- Doctor
create procedure pcdDoctor
@Id_Specialist	varchar(6),
@DoctorName	varchar(255),
@DoctorGender	char(10),
@DateOfBirth	date,
@Phone	varchar(12)
as
begin
	declare @Id_Doctor varchar(6),  @Number int
	if exists(select*from Doctor.Doctor)
	begin
		select @Id_Doctor = Id_Doctor from Doctor.Doctor order by Id_Doctor
		set @Number = substring(@Id_Doctor,2,5)
		if @Number between 1 and 8
			set @Id_Doctor = 'D0000' + convert(varchar(6), @Number+1)
		else
		if @Number between 9 and 98
			set @Id_Doctor = 'D000' + convert(varchar(6), @Number+1)
		else
		if @Number between 99 and 998
			set @Id_Doctor = 'D00' + convert(varchar(6), @Number+1)
		else
		if @Number between 999 and 9998
			set @Id_Doctor = 'D0' + convert(varchar(6), @Number+1)
		else
		if @Number between 9999 and 99998
			set @Id_Doctor = 'D' + convert(varchar(6), @Number+1)
		else
			print 'Data already meets maximum limit'
	end
	else
		set @Id_Doctor = 'D00001'
	
	begin try
	insert Doctor.Doctor
	values(@Id_Doctor, @Id_Specialist, @DoctorName, @DoctorGender,@DateOfBirth,@Phone)
	if @@rowcount > 0
		print 'Data doctor successful inputted'
	else
		print 'Data doctor failed inputted'
	end try
	begin catch
		print 'Error : ' +error_message()
	end catch
end

create procedure pcddelDoctor
@Id_doctor varchar (6)
as
begin
	delete from Doctor.Doctor where @Id_doctor = Id_doctor
	if @@rowcount > 0
	print 'Data doctor successful deleted'
	else
	print 'Data doctor failed deleted'
end

create procedure pcduptDoctor
@Id_Doctor	varchar(6),@Id_Specialist	varchar(6),@DoctorName	varchar(255),@DoctorGender	char(10),@DateOfBirth	date ,@Phone	varchar(12)
as
begin
	update Doctor.Doctor 
	set  Id_Specialist =@Id_Specialist, DoctorName = @DoctorName,DoctorGender = @DoctorGender,DateOfBirth = @DateOfBirth,Phone = @Phone
	where @Id_Doctor= Id_Doctor
	if @@rowcount > 0
	print 'Data doctor successful updated'
	else
	print 'Data doctor failed updated'
end

-- Drug
create procedure pcdDrug
@DrugName	varchar(150),
@DrugType	char(100),
@Stock	int,
@ExpDate	date,
@Price	money
as
begin
	declare @Id_Drug varchar(8),  @Number int
	if exists(select*from Recipe.Drug)
	begin
		select @Id_Drug = Id_Drug from Recipe.Drug order by Id_Drug
		set @Number = substring(@Id_Drug,4,5)
		if @Number between 1 and 8
			set @Id_Drug = 'DRG0000' + convert(varchar(6), @Number+1)
		else
		if @Number between 9 and 98
			set @Id_Drug = 'DRG000' + convert(varchar(6), @Number+1)
		else
		if @Number between 99 and 998
			set @Id_Drug = 'DRG00' + convert(varchar(6), @Number+1)
		else
		if @Number between 999 and 9998
			set @Id_Drug = 'DRG0' + convert(varchar(6), @Number+1)
		else
		if @Number between 9999 and 99998
			set @Id_Drug = 'DRG' + convert(varchar(6), @Number+1)
		else
			print 'Data already meets maximum limit'
	end
	else
		set @Id_Drug = 'DRG00001'
	
	begin try
	insert Recipe.Drug
	values(@Id_Drug, @DrugName,@DrugType,@Stock,@ExpDate,@Price)
	if @@rowcount > 0
		print 'Data drug successful inputted'
	else
		print 'Data drug failed inputted'
	end try
	begin catch
		print 'Error :' +error_message()
	end catch
end

create procedure pcddelDrug
@Id_drug varchar (8)
as
begin
	delete from Recipe.Drug where @Id_drug = Id_drug
	if @@rowcount > 0
	print 'Data drug successful deleted'
	else
	print 'Data drug failed deleted'
end

create procedure pcduptDrug
@Id_Drug varchar(8),@DrugName varchar(150),@DrugType char(100),@Stock int,@ExpDate date,@Price	Money
as
begin
	update Recipe.Drug	
	set  DrugName = @DrugName,DrugType = @DrugType,Stock = @Stock,ExpDate = @ExpDate,Price = @Price
	where @Id_Drug = Id_Drug
	if @@rowcount > 0
	print 'Data drug successful updated'
	else
	print 'Data drug failed updated'
end

-- Recipe Detail
create procedure pcdRecipeDetail
@Id_Recipe	varchar(6),
@Id_Drug	varchar(8),
@Qty	int,
@Dose	varchar(150)
as
begin
	declare @Id_RecipeDetail varchar(7),  @Number int,@ExpDate	date
	if exists(select*from Recipe.RecipeDetail)
	begin
		select @Id_RecipeDetail = Id_RecipeDetail from Recipe.RecipeDetail order by Id_RecipeDetail
		set @Number = substring(@Id_RecipeDetail,3,5)
		if @Number between 1 and 8
			set @Id_RecipeDetail = 'RD0000' + convert(varchar(7), @Number+1)
		else
		if @Number between 9 and 98
			set @Id_RecipeDetail = 'RD000' + convert(varchar(7), @Number+1)
		else
		if @Number between 99 and 998
			set @Id_RecipeDetail = 'RD00' + convert(varchar(7), @Number+1)
		else
		if @Number between 999 and 9998
			set @Id_RecipeDetail = 'RD0' + convert(varchar(7), @Number+1)
		else
		if @Number between 9999 and 99998
			set @Id_RecipeDetail = 'RD' + convert(varchar(7), @Number+1)
		else
			print 'Data already meets maximum limit'
	end
	else
		set @Id_RecipeDetail = 'RD00001'
	begin try
	--select @Id_Drug = a.Id_Drug, @ExpDate = b.ExpDate from Recipe.RecipeDetail a join Recipe.Drug b on a.Id_Drug = b.Id_Drug where a.Id_Drug = @Id_Drug
	--if(@ExpDate <= getdate())
	--	begin
	--		print 'Obat Telah Expyear'
	--		rollback
	--	end
	insert Recipe.RecipeDetail (Id_RecipeDetail, Id_Recipe,Id_Drug,Qty,Dose)
	values(@Id_RecipeDetail, @Id_Recipe,@Id_Drug,@Qty,@Dose)
	if @@rowcount > 0
		print 'Data Berhasil Diinput'
	else
		print 'Data Gagal Diinput'
	end try
	begin catch
		print 'Error :' +error_message()
	end catch
end

create procedure pcddelRecipeDetail
@Id_RecipeDetail varchar (7)
as
begin
	delete from Recipe.RecipeDetail where @Id_RecipeDetail = Id_RecipeDetail
	if @@rowcount > 0
	print 'Data recipe detail successful deleted'
	else
	print 'Data recipe detail failed deleted'
end

create procedure pcduptRecipeDetail
@Id_RecipeDetail	varchar(7),@Id_Recipe	varchar(6),@Id_Drug	varchar(8),@Qty	int,@Dose	varchar(150),@Subtotal	Money
as
begin
	update Recipe.RecipeDetail	
	set  Id_Recipe = @Id_Recipe,Id_Drug = @Id_Drug,Qty = @Qty,Dose = @Dose,Subtotal = @Subtotal
	where @Id_RecipeDetail = Id_RecipeDetail
	if @@rowcount > 0
	print 'Data recipe detail successful updated'
	else
	print 'Data recipe detail failed updated'
end

-- Treatment
create procedure pcdTreatment
@Id_Patient	varchar(6),
@Id_Doctor	varchar(6),
@Diagnose	varchar(150)
as
begin
	declare @Id_Recipe varchar(6),  @Number3 int, @Id_Treatment varchar(6),  @Number int, @Id_Specialist	varchar(6), @Fare	money, @Total money,
	@Id_Payment varchar(8),  @Number2 int
	if exists(select*from Recipe.Recipe)
	begin
		select @Id_Recipe = Id_Recipe from Recipe.Recipe order by Id_Recipe
		set @Number3 = substring(@Id_Recipe,2,5)
		if @Number3 between 1 and 8
			set @Id_Recipe = 'R0000' + convert(varchar(6), @Number3+1)
		else
		if @Number3 between 9 and 98
			set @Id_Recipe = 'R000' + convert(varchar(6), @Number3+1)
		else
		if @Number3 between 99 and 998
			set @Id_Recipe = 'R00' + convert(varchar(6), @Number3+1)
		else
		if @Number3 between 999 and 9998
			set @Id_Recipe = 'R0' + convert(varchar(6), @Number3+1)
		else
		if @Number3 between 9999 and 99998
			set @Id_Recipe = 'R' + convert(varchar(6), @Number3+1)
		else
			print 'Data already meets maximum limit'
	end
	else
		set @Id_Recipe = 'R00001'

	begin try
	insert Recipe.Recipe (Id_Recipe)
	values(@Id_Recipe)
	if @@rowcount > 0
		print 'Data treatment successful inputted'
	else
		print 'Data treatment failed inputted'
	end try
	begin catch
		print 'Error : '+error_message()
	end catch

	if exists(select*from Patient.Treatment)
	begin
		select @Id_Treatment = Id_Treatment from Patient.Treatment order by Id_Treatment
		set @Number = substring(@Id_Treatment,2,5)
		if @Number between 1 and 8
			set @Id_Treatment = 'T0000' + convert(varchar(6), @Number+1)
		else
		if @Number between 9 and 98
			set @Id_Treatment = 'T000' + convert(varchar(6), @Number+1)
		else
		if @Number between 99 and 998
			set @Id_Treatment = 'T00' + convert(varchar(6), @Number+1)
		else
		if @Number between 999 and 9998
			set @Id_Treatment = 'T0' + convert(varchar(6), @Number+1)
		else
		if @Number between 9999 and 99998
			set @Id_Treatment = 'T' + convert(varchar(6), @Number+1)
		else
			print 'Data already meets maximum limit'
	end
	else
		set @Id_Treatment = 'T00001'

	begin try
	insert Patient.Treatment(Id_Treatment,Id_Patient,Id_Doctor,Id_Recipe, Diagnose)
	values(@Id_Treatment, @Id_Patient, @Id_Doctor, @Id_Recipe, @Diagnose)
	if @@rowcount > 0
		print 'Data treatment successful inputted'
	else
		print 'Data treatment failed inputted'
	end try
	begin catch
		print 'Error : ' +error_message()
	end catch

	if exists(select*from Patient.Payment)
	begin
		select @Id_Payment = Id_Payment from Patient.Payment order by Id_Payment
		set @Number2 = substring(@Id_Payment,4,5)
		if @Number2 between 1 and 8
			set @Id_Payment = 'PAY0000' + convert(varchar(6), @Number2+1)
		else
		if @Number2 between 9 and 98
			set @Id_Payment = 'PAY000' + convert(varchar(6), @Number2+1)
		else
		if @Number2 between 99 and 998
			set @Id_Payment = 'PAY00' + convert(varchar(6), @Number2+1)
		else
		if @Number2 between 999 and 9998
			set @Id_Payment = 'PAY0' + convert(varchar(6), @Number2+1)
		else
		if @Number2 between 9999 and 99998
			set @Id_Payment = 'PAY' + convert(varchar(6), @Number2+1)
		else
			print 'Data already meets maximum limit'
	end
	else
		set @Id_Payment = 'PAY00001'

		select @Id_Doctor = a.Id_Doctor, @Id_Specialist = c.Id_Specialist, @Fare = c.Fare from Doctor.Doctor a join Patient.Treatment b
		on a.Id_Doctor = b.Id_Doctor join Doctor.Specialist c on c.Id_Specialist = a.Id_Specialist where b.Id_Doctor = @Id_Doctor
		select @Id_Recipe = b.Id_Recipe, @Total = a.Total from Patient.Treatment b join Recipe.Recipe a on b.Id_Recipe = a.Id_Recipe
		
		insert Patient.Payment(Id_Payment,Id_Treatment,PaymentDoctor,PaymentDrug)
		values(@Id_Payment,@Id_Treatment,@Fare,@Total)
		if @@rowcount > 0
			print 'Data payment successful inputted'
		else
			print 'Data payment failed inputted'
end

create procedure pcddelRecipe
@Id_recipe varchar (6)
as
begin
	delete from Recipe.Recipe where @Id_recipe = Id_recipe
	if @@rowcount > 0
	print 'Data recipe successful deleted'
	else
	print 'Data recipe failed deleted'
end

create procedure pcduptRecipe
@Id_Recipe varchar(6),@DateRecipe date,@Total Money
as
begin
	update Recipe.Recipe 
	set  Total = @Total
	where @Id_Recipe = Id_Recipe
	if @@rowcount > 0
	print 'Data recipe successful updated'
	else
	print 'Data recipe failed updated'
end

create procedure pcddelTreatment
@Id_Treatment varchar (6)
as
begin
	delete from Patient.Treatment where @Id_Treatment = Id_Treatment
	if @@rowcount > 0
	print 'Data treatment successful deleted'
	else
	print 'Data treatment failed deleted'
end

create procedure pcduptTreatment
@Id_Treatment	varchar(6),@Id_Patient	varchar(6),@Id_Doctor	varchar(6),@Id_Recipe	varchar(6),@Diagnose	varchar(150),@DateTreatment	date
as
begin
	update Patient.Treatment	
	set  Id_Patient = @Id_Patient,Id_Doctor = @Id_Doctor,Id_Recipe =@Id_Recipe,Diagnose = @Diagnose,DateTreatment = @DateTreatment
	where @Id_Treatment = Id_Treatment
	if @@rowcount > 0
	print 'Data treatment successful updated'
	else
	print 'Data treatment failed updated'
end

create procedure pcddelPay
@Id_Payment varchar (8)
as
begin
	delete from Patient.Payment where @Id_Payment = Id_Payment
	if @@rowcount > 0
	print 'Data payment successful deleted'
	else
	print 'Data payment failed deleted'
end

create procedure pcduptPay
@Id_Payment	varchar(8),@Id_Treatment	varchar(6),@PaymentDoctor	money,@PaymentDrug	money,@TotalPayment	money
as
begin
	update Patient.Payment	
	set  Id_Treatment = @Id_Treatment,PaymentDoctor = @PaymentDoctor,PaymentDrug = @PaymentDrug,TotalPayment = @TotalPayment
	where @Id_Payment = Id_Payment
	if @@rowcount > 0
	print 'Data berhasil di update'
	else
	print 'Data gagal di update'
end
----------------------------------------------------------------------------------------------------------
/*Trigger*/

--Trigger Recipe Detail
create trigger trgRecipeDetail
on Recipe.RecipeDetail
after insert, update
as
begin
	declare @Stock int
	declare @Id_Drug varchar(8)
	declare @Qty int
	declare @Price money
	declare @Id_RecipeDetail varchar(7)
	declare @total money
	declare @Subtotal money
	declare @Id_Recipe varchar(6)
	declare @TotalPayment money
	declare @PaymentDoctor money
	declare @PaymentDrug money
	declare @Id_Payment varchar(8)

	select @Id_RecipeDetail = b.Id_RecipeDetail, @Id_Drug = b.Id_Drug, @Qty = b.Qty, @Price = a.Price from Recipe.RecipeDetail b join Recipe.Drug a on b.Id_Drug = a.Id_Drug 
	where b.Id_RecipeDetail = Id_RecipeDetail

	update Recipe.RecipeDetail
	set Subtotal = @Price*@Qty where Id_RecipeDetail = @Id_RecipeDetail
	print 'Data subtotal added'

	select @Id_Recipe = Id_Recipe from Recipe.RecipeDetail
	select @Subtotal = sum(Subtotal) from Recipe.RecipeDetail
	where Id_Recipe = @Id_Recipe
	update Recipe.Recipe set Total = @Subtotal where Id_Recipe = @Id_Recipe
	print 'Data subtotal added'

	if @Qty is not null
		update Recipe.Drug
		set Stock = Stock - @Qty where Id_Drug = @Id_Drug
	print 'Data quantity reduced'

	update Patient.Payment
	set PaymentDrug = @Total where Id_Payment = @Id_Payment
	print 'Data payment drug added'
end

-- Trigger Payment
create trigger trgPayment
on Patient.Payment
after insert, update
as
begin
	declare @Id_Payment varchar(8)
	declare @TotalPayment money
	declare @PaymentDoctor money
	declare @PaymentDrug money	
	declare @Id_Recipe varchar(6)
	declare @Total money

	select @Id_Recipe = b.Id_Recipe, @Total = a.Total from Patient.Treatment b join Recipe.Recipe a on b.Id_Recipe = a.Id_Recipe
	select @paymentdoctor = paymentDoctor, @Id_Payment =  Id_Payment from Patient.Payment
	
	update Patient.Payment
	set PaymentDrug = @Total where Id_Payment = @Id_Payment
	print 'Data payment drug update'

	update Patient.Payment
	set TotalPayment = @paymentdoctor + @Total
	where Id_Payment = @Id_Payment
	print 'Data total payment added'
end
----------------------------------------------------------------------------------------------------------
/*View*/

-- view gk diexecute

create view vw_patient_diagnose
as
select b.Id_Treatment,a.Patient_Name,b.Diagnose,b.DateTreatment,c.DoctorName
from Patient.Patient a join Patient.Treatment b 
on a.Id_Patient = b.Id_Patient
join Doctor.Doctor c
on c.id_doctor = b.Id_Doctor

create view vw_patient_payment
as
select b.Id_Treatment,a.Patient_Name, x.DoctorName ,b.Diagnose,b.DateTreatment,c.PaymentDoctor,c.PaymentDrug,c.TotalPayment
from Patient.Patient a join Patient.Treatment b
on a.Id_Patient = b.Id_Patient
join Patient.Payment c
on c.Id_Treatment = b.Id_Treatment join Doctor.Doctor x on b.Id_Doctor = x.Id_Doctor where Id_Payment = 'PAY00001'

create view vw_doctor_full_list
as
select a.Id_Doctor,a.DoctorName,b.Day,b.Time,b.Room,c.Specialist,c.Fare
from Doctor.Doctor a join Doctor.Schedule b 
on a.id_Schedule = b.Id_Schedule
join Doctor.Specialist c
on c.Id_Specialist = a.Id_Specialist

select a.Id_Doctor, a.DoctorName, b.Specialist, a.Phone from Doctor.Doctor a join Doctor.Specialist b on a.Id_Specialist = b.Id_Specialist

create view vw_patient_drug
as
select b.Id_Treatment,a.Patient_Name,b.Diagnose,c.Total,d.Qty,d.Dose,d.Subtotal,
e.DrugName,e.DrugType,e.Stock,e.ExpDate,e.Price
from Patient.Patient a join Patient.Treatment b
on a.Id_Patient = b.Id_Patient
join Recipe.Recipe c
on c.Id_Recipe = b.Id_Recipe 
join Recipe.RecipeDetail d
on d.Id_Recipe = c.Id_Recipe
join Recipe.Drug e
on e.Id_Drug = d.Id_Drug

create view vw_patient_treatment
as
select a.Id_Patient,a.Patient_Name,a.DateOfBirth,a.Address from Patient.Patient a left outer join Patient.Treatment b
on a.Id_Patient = b.Id_Patient where DateTreatment < getdate()

select a.Id_Treatment, b.Patient_Name, c.DoctorName, a.Diagnose, a.DateTreatment from Patient.Treatment a join Patient.Patient b on a.Id_Patient = b.Id_Patient join Doctor.Doctor c on a.Id_Doctor = c.Id_Doctor

select a.Id_Recipe, e.Patient_Name, c.DrugName, c.DrugType, d.Diagnose from Recipe.Recipe a join Recipe.RecipeDetail b on b.Id_Recipe = a.Id_Recipe join Recipe.Drug c on b.Id_Drug = c.Id_Drug join Patient.Treatment d on d.Id_Recipe = a.Id_Recipe join Patient.Patient e on e.Id_Patient = d.Id_Patient

select * from Patient.Treatment

select * from Doctor.Doctor

create view vw_doctor_specilist
as
select b.Id_Doctor,b.DoctorName,a.Specialist, b.Phone from Doctor.Specialist a right outer join Doctor.Doctor b
on a.Id_Specialist = b.Id_Specialist where Specialist = 'General'

create view vw_payment
as
select a.Id_Treatment,a.DateTreatment,a.Diagnose,b.PaymentDoctor,b.PaymentDrug,b.TotalPayment 
from Patient.Treatment a full outer join Patient.Payment b on a.Id_Treatment = b.Id_Treatment
----------------------------------------------------------------------------------------------------------
/*Insert*/

exec pcdAL 'admin', 'adminganteng', '1'
exec pcdAL 'kasir1', 'kasirganteng', '0'

select * from AccessLogin where Username = 'admin' and UPassword = 'adminganteng' and isAdmin = '1'

select count(*) from AccessLogin where Username = 'admin' and UPassword = 'adminganteng' and isAdmin = '1'

-- Patient
exec pcdPatient 'Arneta Sari','1998-03-13','Jl.Kutek No.29 Depok','Female'
exec pcdPatient 'Aril Noah','1992-01-10','Jl.Asia-Afrika No.3 Bandung','Male'
exec pcdPatient 'Beti Suketi','1998-07-06','Jl.Pramuka No.4 Jakarta','Female'
exec pcdPatient 'Charlie Sumono','1990-05-12','Jl.Mahkota No.7 Depok','Male'
exec pcdPatient 'David Herman Sugiono','1988-10-01','Jl.Kukel No.1 Depok','Male'
exec pcdPatient 'Herman Suseno','1997-09-21','Jl.Kutek No.42 Depok','Male'

exec pcdPatient 'Test','1998-02-13','Jl.Melupakan Kenangn','Male'

select * from Patient.Patient

select top 1 Id_Patient from Patient.Patient order by Id_Patient desc;

-- Specialist
exec pcdSpecialist 'General','80000'
exec pcdSpecialist 'Dermatologist','120000'
exec pcdSpecialist 'Dentist','150000'
select * from Doctor.Specialist

select top 1 Id_Specialist from Doctor.Specialist order by Id_Specialist desc
Select Right(Id_Specialist,3) as 'Id_Specialist' from Doctor.Specialist Order by Id_Specialist DESC

-- Doctor
exec pcdDoctor 'SPC001','Yudha','Male','1993-01-01','082211832092'
exec pcdDoctor 'SPC002','Rama','Male','1992-01-18','088809908776'
exec pcdDoctor 'SPC002','Garin','Male','1992-05-02','082211845146'
exec pcdDoctor 'SPC001','Ani','Female','1990-08-03','081254561234'
exec pcdDoctor 'SPC001','Maria','Female','1972-03-30','082298756431'
select * from Doctor.Doctor

select a.Id_Doctor, a.DoctorName, a.Phone, b.Specialist, b.Fare from Doctor.Doctor a join Doctor.Specialist b on a.Id_Specialist = b.Id_Specialist

-- Drug
exec pcdDrug 'Mixagrip','Tablet','12200','2020-12-03','200'
exec pcdDrug 'D-Vit','Tablet','121000','2021-03-06','1500'
exec pcdDrug 'Entrostop','Tablet','22000','2022-07-09','800'
exec pcdDrug 'Analgesik','Tablet','23100','2021-02-05','800 '
exec pcdDrug 'Cephadroxil','Tablet','12390','2020-12-18','850'
exec pcdDrug 'Dolo Neurobion','Tablet','21200','2022-08-24','1800'
exec pcdDrug 'Kalpanax','Cream','2210','2022-09-09','25000'
select * from Recipe.Drug

-- Treatment
exec pcdTreatment 'P00001','D00001','Fever'
exec pcdTreatment 'P00002','D00001','Typus'
exec pcdTreatment 'P00003','D00001','Headache'
exec pcdTreatment 'P00002','D00004','Fever'
exec pcdTreatment 'P00004','D00003','Fever'

exec pcdTreatment 'P00004','D00004','Fever'

select * from Patient.Payment
select*from Patient.Treatment

-- Recipe Detail
exec pcdRecipeDetail 'R00001','DRG00005','10','3x1'
exec pcdRecipeDetail 'R00001','DRG00002','10','3x1'
exec pcdRecipeDetail 'R00002','DRG00001','5','2x1'
exec pcdRecipeDetail 'R00002','DRG00004','5','2x1'
exec pcdRecipeDetail 'R00003','DRG00001','10','3x1'
exec pcdRecipeDetail 'R00003','DRG00006','10','3x1'
exec pcdRecipeDetail 'R00004','DRG00003','12','3X1'
exec pcdRecipeDetail 'R00004','DRG00002','14','3X1'
exec pcdRecipeDetail 'R00005','DRG00005','10','2x1'
exec pcdRecipeDetail 'R00005','DRG00003','15','3x1'

exec pcdRecipeDetail 'R00006','DRG00005','23','3X1'


-------------------------------------------------------------------------------------------------------------------
/*Select*/

select * from Recipe.Drug
select * from Recipe.RecipeDetail
select * from Patient.Payment
select*from Patient.Treatment
select*from Recipe.Recipe

select a.Id_Treatment, b.Patient_Name, a.Diagnose from Patient.Treatment a join Patient.Patient b on a.Id_Patient = b.Id_Patient join Patient.Payment x on a.Id_Treatment = x.Id_Treatment where x.isPay = '0'
/*
select * from Recipe.Drug
delete from Recipe.RecipeDetail
delete from Patient.Payment
delete from Patient.Treatment
delete from Recipe.Recipe
*/
select*from vw_patient_drug

Select Right(Id_Patient,5) as 'Id_Patient' from Patient.Patient Order by Id_Patient DESC

select * from Patient.Patient

delete from Recipe.Recipe

select e.DrugName,e.DrugType,e.ExpDate,d.Dose, d.Qty,e.Price,d.Subtotal
from Patient.Patient a join Patient.Treatment b
on a.Id_Patient = b.Id_Patient
join Recipe.Recipe c
on c.Id_Recipe = b.Id_Recipe 
join Recipe.RecipeDetail d
on d.Id_Recipe = c.Id_Recipe
join Recipe.Drug e
on e.Id_Drug = d.Id_Drug where Id_Treatment = 'T00002'

select * from Doctor.Specialist
select count(Specialist) as Specialist from Doctor.Specialist where Specialist = 'General'