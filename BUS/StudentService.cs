using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StudentService
    {
        private readonly StudentModel _context;

        public StudentService()
        {
            _context = new StudentModel(); // Khởi tạo context
        }

        // Phương thức để lấy danh sách sinh viên
        public List<Student> getAll()
        {
            // Sử dụng _context đã được khởi tạo từ constructor
            return _context.Student.ToList();
        }

        public void AddStudent(Student student)
        {
            try
            {
                _context.Student.Add(student); // Thêm sinh viên vào DbSet
                _context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm sinh viên: " + ex.Message); // Bắt và ném lại lỗi
            }
        }
        public void DeleteStudent(int studentId)
        {

            {
                var student = _context.Student.Find(studentId);
                if (student != null)
                {
                    _context.Student.Remove(student);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Sinh viên không tồn tại.");
                }
            }
        }
        public void UpdateStudent(Student student)
        {
            // Tìm sinh viên theo ID
            var existingStudent = _context.Student.Find(student.StudentID);
            if (existingStudent != null)
            {
                // Cập nhật các thuộc tính
                existingStudent.FullName = student.FullName;
                existingStudent.AverageScore = student.AverageScore;
                existingStudent.FacultyID = student.FacultyID;
                existingStudent.MajorID = student.MajorID;
                existingStudent.Avatar = student.Avatar;

                // Lưu thay đổi vào cơ sở dữ liệu
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Sinh viên không tồn tại."); // Nếu không tìm thấy sinh viên
            }
        }


        public void Delete(int studentId)
        {
            var studentToDelete = _context.Student.Find(studentId);
            if (studentToDelete != null)
            {
                _context.Student.Remove(studentToDelete); // Xóa sinh viên
                _context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }
        }
        public void Update(Student student)
        {
            var existingStudent = _context.Student.Find(student.StudentID);
            if (existingStudent != null)
            {
                // Cập nhật các thuộc tính của sinh viên
                existingStudent.FullName = student.FullName;
                existingStudent.FacultyID = student.FacultyID;
                existingStudent.AverageScore = student.AverageScore;
                existingStudent.MajorID = student.MajorID;

                _context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }
        }
        public void Add(Student student)
        {
            _context.Student.Add(student); // Thêm sinh viên vào DbSet
            _context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
        }


    }
}
