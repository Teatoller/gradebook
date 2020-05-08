// using System.IO;

// namespace Gradebook
// {
//     internal class DiskBook : Book
//     {
//         private string name;

//         public DiskBook(string name) : base(name)
//         {
//             this.name = name;
//         }

//         public override event GradeAddedDelegate GradeAdded;

//         public override void AddGrade(double grade)
//         {
//             using (var writer = File.AppendText($"{Name}.txt"))
//             {
//                 writer.WriteLine(grade);
//                 if(GradeAdded !=null)
//                 {
//                     GradeAdded(this, new EventArgs());
//                 }
//             }
//         }

//         public override Statistics GetStatistics()
//         {
//             throw new System.NotImplementedException();
//         }
//     }
// }