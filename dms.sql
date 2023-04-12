
--
-- 
--


SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";




--
-- Database: `dms`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
CREATE TABLE IF NOT EXISTS `admin` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `surname` varchar(30) NOT NULL,
  `firstname` varchar(30) NOT NULL,
  `lastname` varchar(30) DEFAULT NULL,
  `staffID` varchar(15) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `password` varchar(100) NOT NULL,
  `created_on` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `surname`, `firstname`, `lastname`, `staffID`, `email`, `phone`, `password`, `created_on`) VALUES
(1, 'Imeh', 'Joyce', 'Ada', '1234', 'joyce@gmail.com', '34567890', '1234', '2019-01-20 10:30:45'),
(2, 'Akinniyi', 'Akinbode', 'Bolade', '12345', 'boladebode@gmail.com', '07037351836', '12345', '2019-02-25 20:15:45'),
(3, 'Agbeluyi', 'Oyinlola', 'Aanuoluwapo', '345', 'fhfdghhh', '555555555555', '12', '2019-02-26 08:30:52'),
(4, 'Testing', 'Editing', 'yfdfg', 'dyfggh', 'gdhfgjh', '7898090', 'gdhj', '2019-02-25 20:53:58'),
(5, 'Letters', 'gg', 'gg', 'gg', 'g', 'gg', 'gg', '2019-02-26 16:14:24');

-- --------------------------------------------------------

--
-- Table structure for table `documentstore`
--

DROP TABLE IF EXISTS `documentstore`;
CREATE TABLE IF NOT EXISTS `documentstore` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `studentId` int(11) NOT NULL,
  `semesterId` int(11) NOT NULL,
  `docCategory` varchar(20) NOT NULL,
  `document` varchar(150) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `studentId` (`studentId`),
  KEY `semesterId` (`semesterId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `documentstore`
--

INSERT INTO `documentstore` (`id`, `studentId`, `semesterId`, `docCategory`, `document`) VALUES
(2, 1, 4, 'Course Form', 'C:\\Users\\BOLADE\\Pictures\\DMSImages\\1234Course Formdocument2751.jpg'),
(3, 1, 2, 'Project', 'C:\\Users\\BOLADE\\Pictures\\DMSImages\\1234Projectdocument563.jpg'),
(4, 2, 3, 'Course Form', 'C:\\Users\\BOLADE\\Pictures\\DMSImages\\1234Course Formdocument4958.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `semester`
--

DROP TABLE IF EXISTS `semester`;
CREATE TABLE IF NOT EXISTS `semester` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `session_id` int(11) NOT NULL,
  `semester_name` varchar(20) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `session_id` (`session_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `semester`
--

INSERT INTO `semester` (`id`, `session_id`, `semester_name`) VALUES
(1, 1, 'First Semester'),
(2, 2, 'Summer'),
(3, 1, 'Second Semester'),
(4, 1, 'third Semester');

-- --------------------------------------------------------

--
-- Table structure for table `session`
--

DROP TABLE IF EXISTS `session`;
CREATE TABLE IF NOT EXISTS `session` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `session_name` varchar(15) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `session`
--

INSERT INTO `session` (`id`, `session_name`) VALUES
(1, '2013/2014'),
(2, '2019'),
(3, '2011/2015'),
(4, '1999/2000');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
CREATE TABLE IF NOT EXISTS `student` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `surname` varchar(30) NOT NULL,
  `firstname` varchar(30) NOT NULL,
  `lastname` varchar(30) DEFAULT NULL,
  `matric_num` varchar(15) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `level` varchar(15) NOT NULL,
  `DOB` varchar(50) DEFAULT NULL,
  `created_on` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`id`, `surname`, `firstname`, `lastname`, `matric_num`, `email`, `phone`, `level`, `DOB`, `created_on`) VALUES
(1, 'Joseph', 'Kayode', 'Temidayo', '12345', 'kay@gmal.com', '9876545678', '100 Level', '11 March 2019', '2019-03-11 11:16:11'),
(2, 'Akinniyi', 'Bode', 'Bolade', '1234', 'boladebode@gmail.com', '07037351836', '200 Level', '13 July 1988', '2019-03-11 11:17:49'),
(3, 'Hey', 'First', 'ihih', '34', 'bbbbj', '79888', '300 Level', '11 March 2019', '2019-03-11 16:30:31'),
(4, 'Akinniyi', 'Beedy', 'Bolade', '1234', 'boladebode@gmail.com', '07037351836', '200 Level', '13 July 1988', '2019-03-11 16:35:50'),
(5, 'Hey', 'First', 'Last', '34', 'bbbbj', '79888', '300 Level', '11 March 2019', '2019-03-11 16:41:58');

-- --------------------------------------------------------

--
-- Table structure for table `studentrequirement`
--

DROP TABLE IF EXISTS `studentrequirement`;
CREATE TABLE IF NOT EXISTS `studentrequirement` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `student_id` int(11) NOT NULL,
  `olevel_type` varchar(10) DEFAULT NULL,
  `olevel_result` varchar(150) DEFAULT NULL,
  `jamb_type` varchar(15) DEFAULT NULL,
  `jamb_de` varchar(150) DEFAULT NULL,
  `affidavit` varchar(150) DEFAULT NULL,
  `referece_letter` varchar(150) DEFAULT NULL,
  `birth_certificate` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `student_id` (`student_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `studentrequirement`
--

INSERT INTO `studentrequirement` (`id`, `student_id`, `olevel_type`, `olevel_result`, `jamb_type`, `jamb_de`, `affidavit`, `referece_letter`, `birth_certificate`) VALUES
(3, 2, 'Waec', 'C:\\Users\\BOLADE\\Pictures\\DMSImages\\1234_olevel_4032.jpg', 'Jamb', 'C:\\Users\\BOLADE\\Pictures\\DMSImages\\1234_jambde_045.jpg', 'C:\\Users\\BOLADE\\Pictures\\DMSImages\\1234_affidavit_2563.jpg', 'C:\\Users\\BOLADE\\Pictures\\DMSImages\\1234_ref_letter_2563.jpg', 'C:\\Users\\BOLADE\\Pictures\\DMSImages\\1234_birth_2563.jpg');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `documentstore`
--
ALTER TABLE `documentstore`
  ADD CONSTRAINT `documentstore_ibfk_1` FOREIGN KEY (`studentId`) REFERENCES `student` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `documentstore_ibfk_2` FOREIGN KEY (`semesterId`) REFERENCES `semester` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `semester`
--
ALTER TABLE `semester`
  ADD CONSTRAINT `semester_ibfk_1` FOREIGN KEY (`session_id`) REFERENCES `session` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;


