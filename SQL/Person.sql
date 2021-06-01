create database QueryViewer
GO

use QueryViewer
GO

create table Person (
	id INT,
	first_name VARCHAR(50),
	last_name VARCHAR(50),
	email VARCHAR(50),
	gender VARCHAR(50),
	ip_address VARCHAR(20)
);
insert into Person (id, first_name, last_name, email, gender, ip_address) values (1, 'Kimberli', 'Sherwen', 'ksherwen0@comcast.net', 'Bigender', '11.162.251.45');
insert into Person (id, first_name, last_name, email, gender, ip_address) values (2, 'Sherm', 'Peaddie', 'speaddie1@quantcast.com', 'Bigender', '57.219.122.81');
insert into Person (id, first_name, last_name, email, gender, ip_address) values (3, 'Nolie', 'Tullett', 'ntullett2@yale.edu', 'Female', '163.43.226.187');
insert into Person (id, first_name, last_name, email, gender, ip_address) values (4, 'Iormina', 'Besant', 'ibesant3@reuters.com', 'Female', '216.217.112.158');
insert into Person (id, first_name, last_name, email, gender, ip_address) values (5, 'Courtenay', 'Le Brum', 'clebrum4@sfgate.com', 'Polygender', '13.134.14.187');
insert into Person (id, first_name, last_name, email, gender, ip_address) values (6, 'Madelon', 'Ianitti', 'mianitti5@huffingtonpost.com', 'Agender', '78.114.134.8');
insert into Person (id, first_name, last_name, email, gender, ip_address) values (7, 'Mortie', 'Goodram', 'mgoodram6@senate.gov', 'Polygender', '178.228.222.153');
insert into Person (id, first_name, last_name, email, gender, ip_address) values (8, 'Lamont', 'Beardshall', 'lbeardshall7@google.de', 'Genderfluid', '106.105.242.65');
insert into Person (id, first_name, last_name, email, gender, ip_address) values (9, 'Eadie', 'De Lorenzo', 'edelorenzo8@usatoday.com', 'Female', '227.143.109.174');
insert into Person (id, first_name, last_name, email, gender, ip_address) values (10, 'Vittorio', 'Camacho', 'vcamacho9@amazon.co.jp', 'Polygender', '66.213.20.239');

