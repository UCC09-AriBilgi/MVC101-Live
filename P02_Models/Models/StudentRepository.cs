namespace P02_Models.Models
{
    public class StudentRepository : IStudentRepository
    {


        // DB de olmayan, InMemory türünde bir kayıtlar oluşturuyorum. Ve bunları bir Liste yapısı halinde tutuyorum.

        public List<Student> DBTable()
        {
            return new List<Student>()
            { 
                new Student() {StudentId=1, Name="Ümit KARAÇİVİ", Email="umit.karacivi@outlook.com", Phone="05523346114",Gender="E"},
                new Student() {StudentId=2, Name="Çekdar ÇAPAR", Email="cc@gmail.com", Phone="09998887766",Gender="E"},
                new Student() {StudentId=3, Name="Nisa Öykü YURDAGÜL", Email="noy@gmail.com", Phone="01112223344",Gender="K"},
                new Student() {StudentId=4, Name="Emine Ayça BAŞARAN", Email="eab@gmail.com", Phone="04443335566",Gender="K"}
            };
        }

        public Student Get(int StudentID)
        {
            return DBTable().FirstOrDefault(e => e.StudentId == StudentID) ?? new Student();
        }
    }
}
