/*
SQLyog Community Edition- MySQL GUI v7.01 
MySQL - 4.1.10-nt : Database - bus
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

CREATE DATABASE /*!32312 IF NOT EXISTS*/`bus` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `bus`;

/*Table structure for table `bus_detail` */

DROP TABLE IF EXISTS `bus_detail`;

CREATE TABLE `bus_detail` (
  `num` varchar(20) default NULL,
  `from1` varchar(70) default NULL,
  `to1` varchar(70) default NULL,
  `Type1` varchar(70) default NULL,
  `dt` varchar(70) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `bus_detail` */

insert  into `bus_detail`(`num`,`from1`,`to1`,`Type1`,`dt`) values ('101','MUMBAI','PUNE','AC','2014/03/10 22:36:15'),('102','MUMBAI','SATARA','AC','2014/03/10 22:36:46');

/*Table structure for table `bus_path` */

DROP TABLE IF EXISTS `bus_path`;

CREATE TABLE `bus_path` (
  `bus_no` varchar(40) default NULL,
  `point` varchar(60) default NULL,
  `point_time` varchar(11) default NULL,
  `price` float default NULL,
  `dt` varchar(60) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `bus_path` */

insert  into `bus_path`(`bus_no`,`point`,`point_time`,`price`,`dt`) values ('101','NERUL','9:45',150,'2014/03/11 00:17:34'),('101','LONAVALA','11:15',215,'2014/03/11 00:18:29'),('101','VAKAD','11:45',265,'2014/03/11 00:19:26'),('101','Pune','12:30',500,'2014/03/11 00:20:04');

/*Table structure for table `bus_reserv` */

DROP TABLE IF EXISTS `bus_reserv`;

CREATE TABLE `bus_reserv` (
  `busno` varchar(40) default NULL,
  `travel_dt` varchar(60) default NULL,
  `seatno` int(30) default NULL,
  `event_time` varchar(60) default NULL,
  `tag` varchar(60) default NULL,
  `dt` varchar(60) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `bus_reserv` */

insert  into `bus_reserv`(`busno`,`travel_dt`,`seatno`,`event_time`,`tag`,`dt`) values ('101','2014/03/18',1,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',2,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',3,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',4,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',5,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',6,'Morning','0','2014/03/10 23:27:37'),('101','2014/03/18',7,'Morning','0','2014/03/10 23:27:37'),('101','2014/03/18',8,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',9,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',10,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',11,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',12,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',13,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',14,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',15,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',16,'Morning','0','2014/03/10 23:27:37'),('101','2014/03/18',17,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',18,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',19,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',20,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',21,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',22,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',23,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',24,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',25,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',26,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',27,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',28,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',29,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',30,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',31,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',32,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',33,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',34,'Morning','1','2014/03/10 23:27:37'),('101','2014/03/18',35,'Morning','1','2014/03/10 23:27:37');

/*Table structure for table `bus_sch` */

DROP TABLE IF EXISTS `bus_sch`;

CREATE TABLE `bus_sch` (
  `busno` varchar(30) default NULL,
  `travel_dt` varchar(50) default NULL,
  `frm` varchar(60) default NULL,
  `scr_time` varchar(60) default NULL,
  `to1` varchar(60) default NULL,
  `to_time` varchar(60) default NULL,
  `price` float default NULL,
  `event_time` varchar(60) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `bus_sch` */

insert  into `bus_sch`(`busno`,`travel_dt`,`frm`,`scr_time`,`to1`,`to_time`,`price`,`event_time`) values ('101','2014/03/18','MUMBAI','9:0','PUNE','12:45',500,'Morning');

/*Table structure for table `cust_reserv` */

DROP TABLE IF EXISTS `cust_reserv`;

CREATE TABLE `cust_reserv` (
  `id` int(11) default NULL,
  `username` varchar(60) default NULL,
  `busno` varchar(60) default NULL,
  `travel_dt` varchar(60) default NULL,
  `seatno` varchar(30) default NULL,
  `custname` varchar(70) default NULL,
  `gender` varchar(60) default NULL,
  `age` varchar(60) default NULL,
  `mobileno` varchar(60) default NULL,
  `emailid` varchar(60) default NULL,
  `cardno` varchar(60) default NULL,
  `cadname` varchar(60) default NULL,
  `cww` varchar(60) default NULL,
  `price` float default NULL,
  `active` varchar(60) default NULL,
  `dt` varchar(60) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `cust_reserv` */

insert  into `cust_reserv`(`id`,`username`,`busno`,`travel_dt`,`seatno`,`custname`,`gender`,`age`,`mobileno`,`emailid`,`cardno`,`cadname`,`cww`,`price`,`active`,`dt`) values (1,'ABS',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2,'SACHIN','101','2014/03/18','11','','Male','','','','','','',215,'N','2014/03/13 17:25:42'),(3,'SACHIN','101','2014/03/18','31','','Male','','','','','','',215,'N','2014/03/13 17:27:36'),(4,'SACHIN','101','2014/03/18','7','','Male','','','','','','',215,'Y','2014/03/13 17:29:28'),(5,'SACHIN','101','2014/03/18','6','','-1','','','','','','',215,'Y','2014/03/13 17:32:57'),(6,'SACHIN','101','2014/03/18','16','pratibha','Male','12','9766425971','pratibha@gmail.com','12345','pratibha','123',215,'Y','2014/03/13 18:00:01');

/*Table structure for table `feedbacktable` */

DROP TABLE IF EXISTS `feedbacktable`;

CREATE TABLE `feedbacktable` (
  `name` varchar(30) default NULL,
  `email` varchar(30) default NULL,
  `msg` text,
  `tag` varchar(10) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `feedbacktable` */

insert  into `feedbacktable`(`name`,`email`,`msg`,`tag`) values ('SACHIN NIKAM','pratibha@gmail.com','fff ','N');

/*Table structure for table `user_table` */

DROP TABLE IF EXISTS `user_table`;

CREATE TABLE `user_table` (
  `name` varchar(60) default NULL,
  `username` varchar(30) default NULL,
  `password` varchar(30) default NULL,
  `emailid` varchar(60) default NULL,
  `city` varchar(60) default NULL,
  `tag` int(11) default NULL,
  `dt` varchar(20) default NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `user_table` */

insert  into `user_table`(`name`,`username`,`password`,`emailid`,`city`,`tag`,`dt`) values ('Nilesh Kadam','NILESH','123','pratibha@','Nerul',1,'08-Mar-2014'),('Pramod Nikam','praod','123','pramodnikam@gmail.co','Nerul',2,'08-Mar-2014'),('Priya Nikam','priya','123','priya','Nerul',3,'08-Mar-2014'),('VIPIN NIKAM','VIPIN','VIPIN','vipin.nikam.71@facebook.com','NERUL',2,'2014/03/09 12:43:53'),('SACHIN NIKAM','SACHIN','123','sachinnikam@gmail.com','NERUL',2,'2014/03/09 14:55:35'),('NITIN NIKAM','NITIN','123','priyanikam 1993@gmail.com','NERUL',3,'2014/03/10 00:05:23'),('GEETA KADAM','GEETA','123','priyanikam 1993@gmail.com','NERUL',3,'2014/03/13 17:48:51');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
