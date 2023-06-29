CREATE DATABASE SweetHome;
use SweetHome;
CREATE TABLE users (
  id INT NOT NULL,
  username VARCHAR(32) NOT NULL,
  password VARCHAR(64) NOT NULL,
  PRIMARY KEY (username)
);
Insert Into users (id, username, password)
Values (1, 'nguyencaoan', 'cnttk61')
Drop table users