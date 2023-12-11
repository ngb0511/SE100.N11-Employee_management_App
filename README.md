# SE100.N11 - Phương pháp phát triển phần mềm hướng đối tượng
### Giảng viên hướng dẫn: Huỳnh Hồ Thị Mộng Trinh

## Phần mềm quản lý nhân viên
Ứng dụng dùng để quản lý nhân sự lao động của doanh nghiệp

## Chức năng ứng dụng:

- ## Quản lý công ty:
     -  Quản lý thông tin nhân viên
     -  Quản lý thông tin phòng ban
     -  Quản lý tài khoản
     -  Báo cáo, thống kê danh sách nhân viên theo từng yêu cầu
     -  Thống kê khen thưởng, kỷ luật
 - ## Quản lý thông tin người dùng:
      -  Đăng nhập
      -  Đăng ký
      -  Thay đổi mật khẩu
      -  Phân quyền (admin-nhân viên)
 - ## Quản lý thông tin nhân viên:
      -  Lưu trữ thông tin chi tiết từng cá nhân (họ tên, tuổi, địa chỉ,sdt..)
      -  Lưu trữ trình độ, chuyên môn, hệ số lương, mức lương cơ bản
      -  Quản lý chấm công, tình hình nghỉ phép của nhân viên
      -  Thêm, xóa, cập nhật thông tin trên
 - ## Quản lý phòng ban:
      -  Lưu trữ thông tin trưởng phòng
      -  Quản lý số lượng nhân viên thuộc phòng ban 
      -  Quản lý thống kê khen thưởng kỷ luật
      -  Thêm, sửa danh sách nhân viên khen thưởng
      -  Thêm, sửa danh sách nhân viên kỷ luật
  - ## Quản lý báo cáo,thống kê:
      -  Danh sách nhân viên theo phòng ban
      -  Danh sách nhân viên theo trình độ chuyên môn
      -  Danh sách nhân viên theo chức vụ
      -  In danh sách nhân viên theo từng yêu cầu
      -  Biểu đồ thống kê
      -  Thống kê hiệu suất làm việc của nhân viên, hiệu suất của từng phòng ban
  
## Công nghệ và ngôn ngữ
   - ## Ngôn ngữ:
       - Ngôn ngữ lập trình: C#
       - Ngôn ngữ cơ sở dữ liệu sql
   - ## Công nghệ:
       - Visual studio 
       - Microsoft sql server management 18

## Kiến trúc 
Phần mềm sử dụng Mô hình 3 layer, 3 tiers là mô hình kết nối đến CSDL thông qua các lớp: DTO, BUS và DAO.

## Hướng dẫn cài đặt:
Môi trường cần thiết:
       - Trình soạn thảo: Visual Studio
       - Database: Microsoft SQL Server Management Studio
Các bước cài đặt:
       - Bước 1: Tạo database bằng file QLNV.sql
       - Bước 2: Kết nối database với Visual Studio
       - Bước 3: Chỉnh sửa ConnectionString trong file .\src\DAL\KetNoi.cs
       - Bước 4: Build và Start Project


  
