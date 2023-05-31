-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.0.45-community-nt


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema abueg
--

CREATE DATABASE IF NOT EXISTS abueg;
USE abueg;

--
-- Definition of table `back subject tbl`
--

DROP TABLE IF EXISTS `back subject tbl`;
CREATE TABLE `back subject tbl` (
  `BackSubjectID` int(10) unsigned NOT NULL auto_increment,
  `SubjectID` int(10) unsigned NOT NULL,
  `TransferreID` int(10) unsigned NOT NULL,
  PRIMARY KEY  (`BackSubjectID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `back subject tbl`
--

/*!40000 ALTER TABLE `back subject tbl` DISABLE KEYS */;
INSERT INTO `back subject tbl` (`BackSubjectID`,`SubjectID`,`TransferreID`) VALUES 
 (4,1,2);
/*!40000 ALTER TABLE `back subject tbl` ENABLE KEYS */;


--
-- Definition of table `enrollment tbl`
--

DROP TABLE IF EXISTS `enrollment tbl`;
CREATE TABLE `enrollment tbl` (
  `EnrollmentID` int(10) unsigned NOT NULL auto_increment,
  `UserID` int(10) unsigned NOT NULL,
  `StudentID` int(10) unsigned NOT NULL,
  `YearLevel` varchar(15) NOT NULL,
  `SchoolYear` varchar(10) NOT NULL,
  PRIMARY KEY  (`EnrollmentID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `enrollment tbl`
--

/*!40000 ALTER TABLE `enrollment tbl` DISABLE KEYS */;
/*!40000 ALTER TABLE `enrollment tbl` ENABLE KEYS */;


--
-- Definition of table `permanentrecord`
--

DROP TABLE IF EXISTS `permanentrecord`;
CREATE TABLE `permanentrecord` (
  `Permanentid` int(10) unsigned NOT NULL auto_increment,
  `Subjectid` varchar(15) NOT NULL,
  `1stGrading` varchar(15) default NULL,
  `2ndGrading` varchar(15) default NULL,
  `3rdGrading` varchar(15) default NULL,
  `4thGrading` varchar(15) default NULL,
  `FinalRating` varchar(15) default NULL,
  `UserID` varchar(15) default NULL,
  `Studentid` varchar(15) default NULL,
  `SchoolYear` varchar(45) default NULL,
  `YearLevel` varchar(20) default NULL,
  `SchoolName` varchar(45) default NULL,
  `Remarks` varchar(15) default NULL,
  `TeacherID` varchar(45) default NULL,
  PRIMARY KEY  USING BTREE (`Permanentid`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `permanentrecord`
--

/*!40000 ALTER TABLE `permanentrecord` DISABLE KEYS */;
INSERT INTO `permanentrecord` (`Permanentid`,`Subjectid`,`1stGrading`,`2ndGrading`,`3rdGrading`,`4thGrading`,`FinalRating`,`UserID`,`Studentid`,`SchoolYear`,`YearLevel`,`SchoolName`,`Remarks`,`TeacherID`) VALUES 
 (1,'001','81','82','83','84','85','1','2','2012-2013','second Year','Ipilan','pass',''),
 (2,'002','89','88','90','94','80','2','2','2012-2013','SecondYear','Abueg','pass',''),
 (3,'','','','',' ','','','','','','','',''),
 (4,'4','82','83','78','90','90','5','4','2012-2013','third year','Abueg','pass','');
/*!40000 ALTER TABLE `permanentrecord` ENABLE KEYS */;


--
-- Definition of table `requirements`
--

DROP TABLE IF EXISTS `requirements`;
CREATE TABLE `requirements` (
  `RequirementID` int(10) unsigned NOT NULL auto_increment,
  `SchoolYear` varchar(45) NOT NULL,
  `RequirementsName` varchar(45) NOT NULL,
  `TypeOfStudent` varchar(45) NOT NULL,
  PRIMARY KEY  (`RequirementID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `requirements`
--

/*!40000 ALTER TABLE `requirements` DISABLE KEYS */;
INSERT INTO `requirements` (`RequirementID`,`SchoolYear`,`RequirementsName`,`TypeOfStudent`) VALUES 
 (1,'2012-2013','BC','New'),
 (2,'2012-2013','Cedula','New'),
 (3,'2012-2013','Good Moral','Old'),
 (4,'2012-2013','Form 137A','New'),
 (5,'2012-2013','BC','Transferee'),
 (6,'efewtet','fdfd','fdfd');
/*!40000 ALTER TABLE `requirements` ENABLE KEYS */;


--
-- Definition of table `sectioning`
--

DROP TABLE IF EXISTS `sectioning`;
CREATE TABLE `sectioning` (
  `sectioningID` int(10) unsigned NOT NULL auto_increment,
  `Yearlevel` varchar(45) NOT NULL,
  `YearSection` varchar(45) NOT NULL,
  `SchoolYear` varchar(45) NOT NULL,
  PRIMARY KEY  (`sectioningID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sectioning`
--

/*!40000 ALTER TABLE `sectioning` DISABLE KEYS */;
INSERT INTO `sectioning` (`sectioningID`,`Yearlevel`,`YearSection`,`SchoolYear`) VALUES 
 (1,'1','1','2'),
 (2,'','',''),
 (3,'','',''),
 (4,'00-001','00-001','00-001');
/*!40000 ALTER TABLE `sectioning` ENABLE KEYS */;


--
-- Definition of table `sectionyear`
--

DROP TABLE IF EXISTS `sectionyear`;
CREATE TABLE `sectionyear` (
  `YearSectionID` int(10) unsigned NOT NULL auto_increment,
  `YearLevel` varchar(20) NOT NULL,
  `Section` varchar(25) NOT NULL,
  `SchoolYear` varchar(20) NOT NULL,
  PRIMARY KEY  (`YearSectionID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sectionyear`
--

/*!40000 ALTER TABLE `sectionyear` DISABLE KEYS */;
INSERT INTO `sectionyear` (`YearSectionID`,`YearLevel`,`Section`,`SchoolYear`) VALUES 
 (1,'First Year','gold','2012-2013');
/*!40000 ALTER TABLE `sectionyear` ENABLE KEYS */;


--
-- Definition of table `student`
--

DROP TABLE IF EXISTS `student`;
CREATE TABLE `student` (
  `StudentID` int(10) unsigned NOT NULL auto_increment,
  `Lname` varchar(20) NOT NULL,
  `Fname` varchar(20) NOT NULL,
  `Mi` varchar(20) NOT NULL,
  `Dateofbirth` varchar(20) NOT NULL,
  `PlaceofBirth` varchar(45) NOT NULL,
  `Gender` varchar(20) NOT NULL,
  `CivilStatus` varchar(20) NOT NULL,
  `Age` varchar(10) NOT NULL,
  `Address` varchar(45) NOT NULL,
  `Religion` varchar(20) NOT NULL,
  PRIMARY KEY  (`StudentID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` (`StudentID`,`Lname`,`Fname`,`Mi`,`Dateofbirth`,`PlaceofBirth`,`Gender`,`CivilStatus`,`Age`,`Address`,`Religion`) VALUES 
 (1,'cbvbxcc','bcvnvc','','2012-08-08','','','','','',''),
 (2,'Nuh','Joan','Yes','2012-07-12','Lada Brookes Point palawan','Female','Single','14','Barong-barong, Brookes Point Palawan','Catholic'),
 (3,'Lasala','Maribel','Diola','1995-08-18','Ipilan Brookes Point Palawan','Single','','Catholic','Lada','Lada'),
 (4,'Lasala','Arnold','None','1989-09-01','Maasin Brookes Point Palawan','Male','Single','14','Barong-barong Brookes Point Palawan','Catholic'),
 (5,'Maribel','Gomez','Analiza','1997-06-03','Barong-barong ','Female','Single','14','Lada Brookes Point Palawan','Catholic'),
 (6,'Alwin','Rosadeño','Asman','1993-06-04','Palawan','Male','Single','13','Palawan','Bapist'),
 (7,'Maribel','Mutia','Diola','1992-06-22','Palawan','Female','Single','14','Lada','Catholic'),
 (8,'Melendres','Jem','Ravalo','1988-08-20','Barong Barong Brooke\'s Point Palawan','Male','Single','20','Barong Barong Brooke\'s Point Palawan','Roman Catholic'),
 (9,'','','','2012-04-06','','','','','','');
INSERT INTO `student` (`StudentID`,`Lname`,`Fname`,`Mi`,`Dateofbirth`,`PlaceofBirth`,`Gender`,`CivilStatus`,`Age`,`Address`,`Religion`) VALUES 
 (10,'vzcbvzxcb','vbzxvxz','','2012-08-08','bbmcbmcb','','','bmbmcbm','bmbmcbm','bmbmcbm');
/*!40000 ALTER TABLE `student` ENABLE KEYS */;


--
-- Definition of table `studentrequirement`
--

DROP TABLE IF EXISTS `studentrequirement`;
CREATE TABLE `studentrequirement` (
  `Student Requirement ID` int(10) unsigned NOT NULL auto_increment,
  `Student ID` int(10) unsigned NOT NULL,
  `Requirement ID` int(10) unsigned NOT NULL,
  `School Year` varchar(20) NOT NULL,
  `UserID` int(10) unsigned NOT NULL,
  PRIMARY KEY  (`Student Requirement ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `studentrequirement`
--

/*!40000 ALTER TABLE `studentrequirement` DISABLE KEYS */;
INSERT INTO `studentrequirement` (`Student Requirement ID`,`Student ID`,`Requirement ID`,`School Year`,`UserID`) VALUES 
 (1,2,3,'2012-2013',5),
 (2,3,2,'2012-2013',6);
/*!40000 ALTER TABLE `studentrequirement` ENABLE KEYS */;


--
-- Definition of table `subject`
--

DROP TABLE IF EXISTS `subject`;
CREATE TABLE `subject` (
  `SubjectID` int(10) unsigned NOT NULL auto_increment,
  `SubjectName` varchar(45) NOT NULL,
  `Units` varchar(45) NOT NULL,
  `SchoolYear` varchar(45) NOT NULL,
  PRIMARY KEY  (`SubjectID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subject`
--

/*!40000 ALTER TABLE `subject` DISABLE KEYS */;
INSERT INTO `subject` (`SubjectID`,`SubjectName`,`Units`,`SchoolYear`) VALUES 
 (1,'CS35','3','2012-2013'),
 (2,'Filipino','3','2012-2013'),
 (3,'English','3','2012-2013'),
 (4,'math','5','2012-2013'),
 (5,'','','');
/*!40000 ALTER TABLE `subject` ENABLE KEYS */;


--
-- Definition of table `teacher`
--

DROP TABLE IF EXISTS `teacher`;
CREATE TABLE `teacher` (
  `TeacherID` int(10) unsigned NOT NULL auto_increment,
  `Fname` varchar(45) NOT NULL,
  `Mname` varchar(45) NOT NULL,
  `Lname` varchar(45) NOT NULL,
  `Address` varchar(45) NOT NULL,
  `ContactNumber` varchar(45) NOT NULL,
  `Position` varchar(45) NOT NULL,
  `TeacherStatus` varchar(10) NOT NULL,
  PRIMARY KEY  (`TeacherID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `teacher`
--

/*!40000 ALTER TABLE `teacher` DISABLE KEYS */;
INSERT INTO `teacher` (`TeacherID`,`Fname`,`Mname`,`Lname`,`Address`,`ContactNumber`,`Position`,`TeacherStatus`) VALUES 
 (1,'arnld','Diola','Mutia','Lada','09269713685','Teacher','Teacher I'),
 (2,'Alwin','Asman','Rosadeño','Brooke\'s Point Palawan','09061751414','Single','Principal'),
 (3,'csa','','','','','',''),
 (4,'','','','','','',''),
 (5,'moo','l','jan','','77777','single','');
/*!40000 ALTER TABLE `teacher` ENABLE KEYS */;


--
-- Definition of table `transferee`
--

DROP TABLE IF EXISTS `transferee`;
CREATE TABLE `transferee` (
  `TransfereeID` int(10) unsigned NOT NULL auto_increment,
  `StudentID` varchar(45) NOT NULL,
  `NameOfSchool` varchar(45) NOT NULL,
  `Address` varchar(45) NOT NULL,
  `YearAttended` varchar(45) NOT NULL,
  `SchoolYearAttended` varchar(45) NOT NULL,
  PRIMARY KEY  (`TransfereeID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transferee`
--

/*!40000 ALTER TABLE `transferee` DISABLE KEYS */;
/*!40000 ALTER TABLE `transferee` ENABLE KEYS */;


--
-- Definition of table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `UserID` int(10) unsigned NOT NULL auto_increment,
  `Username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `FName` varchar(25) NOT NULL,
  `LName` varchar(25) NOT NULL,
  `Usertype` varchar(25) NOT NULL,
  `Userstatus` varchar(25) NOT NULL,
  `SecurityQuestion` varchar(60) NOT NULL,
  `SecurityAnswer` varchar(25) NOT NULL,
  `Contactnumber` varchar(25) NOT NULL,
  `DateRegister` date default NULL,
  PRIMARY KEY  (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` (`UserID`,`Username`,`password`,`FName`,`LName`,`Usertype`,`Userstatus`,`SecurityQuestion`,`SecurityAnswer`,`Contactnumber`,`DateRegister`) VALUES 
 (1,'alwinnn','winwin','Alwin','Rosadeño','admin','Single','What is your favourite subject?','English','09061751414','2012-03-12'),
 (2,'Staff01','Staff01','Staff','Staff','Staff','Active','Who gave you your name?','My Father','','2012-09-14');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;


--
-- Definition of table `year section`
--

DROP TABLE IF EXISTS `year section`;
CREATE TABLE `year section` (
  `YearSecionID` int(10) unsigned NOT NULL auto_increment,
  `YearLevel` varchar(45) NOT NULL,
  `Section` varchar(45) NOT NULL,
  `SchoolYear` varchar(45) NOT NULL,
  PRIMARY KEY  (`YearSecionID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `year section`
--

/*!40000 ALTER TABLE `year section` DISABLE KEYS */;
/*!40000 ALTER TABLE `year section` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
