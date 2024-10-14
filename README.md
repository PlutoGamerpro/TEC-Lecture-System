# 🎓TEC Lecture System 🎤📚

🎉Welcome to the TEC Lecture System! This cool console app built in C# simulates a full-on lecture management system. Teachers create lectures, students enroll, and the magic happens when the teacher starts the lecture! Let's jump in and see how it all works! 💡🔥

---

## ✨ Main Features 🛠️

- 🧑‍🏫 **Create Lectures**: Teachers can create lectures on any topic.
- 🙋‍♂️ **Enroll Students**: Students can sign up for lectures.
- 🎬 **Start Lectures**: Teachers start lectures, showcasing all the details.
- 👨‍👩‍👧‍👦 **Manage Participants**: Keep track of multiple lectures and student enrollments.

---
## 📁 **Project Structure** 🌳 
```bash
Foredrag/
├── Program.cs    # Main program that ties everything together
├── Person.cs     # Base class for common properties (Name and Age)
├── Lære.cs       # Inherits from Person and manages lectures
├── Foredrag.cs   # Manages lecture details, inherits from Lokale
├── Elev.cs       # Inherits from Person, allows students to join lectures
└── Lokale.cs     # Represents the lecture room
```
---
## 📜 **How the Code Works** 🚀
1️⃣ **Program.cs** 🖥️
- This is the entry point of the program. Here, we create an instance of a teacher and students. The teacher creates lectures, and students enroll in them. Finally, the teacher starts a lecture.
```Csharp
Lære lærer = new Lære("Lærer Mads", 35, "Matematik");
Foredrag foredrag1 = lærer.OpretFordrag("Introduktion til algebra");
Elev elev1 = new Elev("Elev1, Peter", 5);
elev1.TilMeldFordrag(foredrag1);
lærer.StartForedrag(foredrag1);
```
- 👨‍🏫 Teacher ```(Lære)```: Creates a lecture
- 👨‍🎓 Student ```(Elev)```: Enrolls in the lecture
- 📚 Lecture ```(Foredrag)```: Starts and displays information
---
 2️⃣ **Person.cs** 🧑👩
- 🧑‍🏫 The base class for all persons in the system. It stores the common properties of a person like name and age.
```Csharp
public class Person
{
    public string Navn { get; set; }
    public int Alder { get; set; }
}
```
- 🌟 Inheritance: This class is inherited by```Lære``` (Teacher) and ```Elev``` (Student).
- 🎓 OpretFordrag(): Creates a new lecture.
- 🎬 StartForedrag(): Starts the lecture and prints details.
---  
3️⃣ **Lære.cs** 👩‍🏫
-The Teacher class that inherits from ```Person```. Teachers can create lectures and start them. They manage their own list of lectures too!
```Csharp
public class Lære : Person
{
    public string Fag { get; set; } 
    public List<Foredrag> ForedragsListe { get; set; }
}
```
- 🏗️ ```OpretFordrag()```: Creates a new lecture.
- 🏁 ```StartForedrag()```: Starts the lecture and prints details
---
4️⃣ Foredrag.cs 🏫
- 🏫 This class represents the lecture. It stores information like the subject, number of students attending, and connects the lecture to the teacher.
```Csharp
public class Foredrag : Lokale
{
    public int AntalElever { get; set; }
    public void StartedFordrag() 
    {
        Console.WriteLine("Foredrag er started...");
    }
}
```
- 💡 Lecture Info: Displays the lecture name, teacher, and details when it starts.
---  
5️⃣ Elev.cs 👨‍🎓
- The Student class that inherits from ```Person```. Students can enroll in any lecture they like!
```Csharp
public class Elev : Person
{
    public List<Foredrag> ForedragListe { get; set; }
}
```
- ✍️ ```TilMeldFordrag()```: Adds the student to the lecture and increases the number of participants.
---
6️⃣ Lokale.cs 🏫
- 🏫 This class represents the lecture room, adding a bit of context to where the lecture takes place. ```Foredrag``` (Lecture) inherits from this to associate each lecture with a room name.
```Csharp
public class Lokale
{
    public string Navn { get; set; }
}
```
---
## 🎉 Conclusion 🎯
- That's it! 🎓 You've just explored a basic lecture management system, showcasing the power of Object-Oriented Programming in C#. Whether you're a student, a teacher, or just a code enthusiast, there's something here for everyone! Feel free to explore, contribute, and learn! 💻💡

---

## 🧑‍🏫 **More Resources & Tutorials**

Check out these amazing resources for more information and advanced coding skills: 📚

If you're looking to deepen your understanding, here are some helpful resources you might find useful:

- 🌟 [Official Visual Studio Documentation](https://docs.microsoft.com/en-us/visualstudio/)
- 📚 [My Coding Tutorials on YouTube](https://www.youtube.com/@CodeByScript)
- 🚀 [Explore My Projects Here!](https://github.com/PlutoGamerpro?tab=stars)  

Feel free to explore these if you're interested! 😊
