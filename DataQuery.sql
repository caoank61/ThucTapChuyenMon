CREATE DATABASE SweetHome;
use SweetHome;
CREATE TABLE users (
	id INT NOT NULL,
  username VARCHAR(32) NOT NULL,
  
  password VARCHAR(64) NOT NULL,
  full_name VARCHAR(64) NOT NULL,
  phonenumber VARCHAR(10) NOT NULL,
  email VARCHAR(64) NOT NULL,
  address VARCHAR(128) NOT NULL,
  PRIMARY KEY (username)
);