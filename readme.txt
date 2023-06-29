#ThucTapChuyenMon
Hướng dẫn cách cài đặt và sử dụng phần mềm SweetHome
B1: Cài đặt Visual Studio theo link: https://visualstudio.microsoft.com/downloads/
B2: Cài đặt SSMS thoe link: https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16
B3: Cài đặt Andruino IDE theo link: https://www.arduino.cc/en/software
B4: Mở file DataQuery.sql với đường dẫn \ThucTapChuyenMon\DataQuery.sql
	B4.1: Bôi đen câu lệnh CREATE DATABASE SweetHome; và nhấn Execute
	B4.2: Bôi đen câu lệnh use SweetHome; và nhấn Execute
	B4.3: Bôi đen câu lệnh CREATE TABLE users (
  					id INT NOT NULL,
  					username VARCHAR(32) NOT NULL,
  					password VARCHAR(64) NOT NULL,
  					PRIMARY KEY (username)); và nhấn Execute
	B4.4: Bôi đen câu lệnh Insert Into users (id, username, password) Values (1, 'nguyencaoan', 'cnttk61') và nhấn Execute
B5: Mở file TTCM.sln với đường dẫn \ThucTapChuyenMon\TTCN.sln
	B5.1: Thực hiện kết nối cơ sở dữ liệu với DB SweetHone
	B5.2: Thay đổi connectionString ở file Form1.cs dòng 38
B6: Kết nối thiết bị phần cứng Andruino với máy tính
B7: Khởi chạy chương trình

B8: Đăng nhập phần mềm với tên đăng nhập: nguyencaoan & password: cnttk61
B9: Trải nghiệm các tính năng của phần mềm 
