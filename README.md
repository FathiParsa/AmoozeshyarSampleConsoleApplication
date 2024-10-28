<div align="left" style="position: relative;">
<img src="https://img.icons8.com/?size=512&id=55494&format=png" align="right" width="30%" style="margin: -20px 0 0 20px;">
<h1>AMOOZESHYAR</h1>
<p align="left">
	<em><code>❯ For Managing University And Stuff Like That </code></em>
</p>
<p align="left">
	<img src="https://img.shields.io/github/license/FathiParsa/AmoozeshyarSampleConsoleApplication?style=default&logo=opensourceinitiative&logoColor=white&color=0080ff" alt="license">
	<img src="https://img.shields.io/github/last-commit/FathiParsa/AmoozeshyarSampleConsoleApplication?style=default&logo=git&logoColor=white&color=0080ff" alt="last-commit">
	<img src="https://img.shields.io/github/languages/top/FathiParsa/AmoozeshyarSampleConsoleApplication?style=default&color=0080ff" alt="repo-top-language">
	<img src="https://img.shields.io/github/languages/count/FathiParsa/AmoozeshyarSampleConsoleApplication?style=default&color=0080ff" alt="repo-language-count">
</p>
<p align="left"><!-- default option, no dependency badges. -->
</p>
<p align="left">
	<!-- default option, no dependency badges. -->
</p>
</div>
<br clear="right">

## 🔗 Table of Contents

- [📍 Overview](#-overview)
- [👾 Features](#-features)
- [📁 Project Structure](#-project-structure)
  - [📂 Project Index](#-project-index)
- [🚀 Getting Started](#-getting-started)
  - [☑️ Prerequisites](#-prerequisites)
  - [⚙️ Installation](#-installation)
  - [🤖 Usage](#🤖-usage)
  - [🧪 Testing](#🧪-testing)
- [📌 Project Roadmap](#-project-roadmap)
- [🔰 Contributing](#-contributing)
- [🎗 License](#-license)
- [🙌 Acknowledgments](#-acknowledgments)

---

## 📍 Overview

<code>❯ Welcome to the University Management System! This is a console application written in C# that allows users to manage students and classes in a university setting. The application uses SQL Server as its database to store and manage data efficiently. With this system, you can easily add or remove students and classes, assign students to classes, and view the full schedule of classes along with the students enrolled in them.</code>

---

## 👾 Features
<code>❯ 1. Add Student: Easily add new students to the database with their relevant information.
 2. Remove Student: Remove students from the database when they are no longer enrolled.
 3. Add Class: Create new classes in the university system.
 4. Remove Class: Delete classes that are no longer offered.
 5. Pick a Class for a Student: Assign one or more classes to a student.
 6. Remove Specific Student from Class: Unenroll a student from a specific class.
 7. Show Full Schedule of Classes and Students: View a complete schedule that lists all classes and the students enrolled in each.
User-friendly Console Interface: Navigate through options easily using a simple menu interface.</code>

---

## 📁 Project Structure

```sh
└── AmoozeshyarSampleConsoleApplication/
    ├── Amoozeshyar
    │   ├── Amoozeshyar.csproj
    │   ├── Program.cs
    │   └── ValidateInput.cs
    ├── Amoozeshyar.sln
    ├── DataAccessLayer
    │   ├── DataAccessLayer.csproj
    │   └── SqlHelper.cs
    ├── Model
    │   ├── Model.csproj
    │   ├── Result.cs
    │   ├── Student.cs
    │   ├── StudentUniversityClasses.cs
    │   └── UniversityClasses.cs
    └── README.md
```


### 📂 Project Index
<details open>
	<summary><b><code>AMOOZESHYARSAMPLECONSOLEAPPLICATION/</code></b></summary>
	<details> <!-- __root__ Submodule -->
		<summary><b>__root__</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication/blob/master/Amoozeshyar.sln'>Amoozeshyar.sln</a></b></td>
				<td><code>❯ Project Solution </code></td>
			</tr>
			</table>
		</blockquote>
	</details>
	<details> <!-- Amoozeshyar Submodule -->
		<summary><b>Amoozeshyar</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication/blob/master/Amoozeshyar/Program.cs'>Program.cs</a></b></td>
				<td><code>❯ Main Program Class </code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication/blob/master/Amoozeshyar/ValidateInput.cs'>ValidateInput.cs</a></b></td>
				<td><code>❯ Class For Implementing Validational Functions </code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication/blob/master/Amoozeshyar/Amoozeshyar.csproj'>Amoozeshyar.csproj</a></b></td>
				<td><code>❯ i dn what is this</code></td>
			</tr>
			</table>
		</blockquote>
	</details>
	<details> <!-- DataAccessLayer Submodule -->
		<summary><b>DataAccessLayer</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication/blob/master/DataAccessLayer/SqlHelper.cs'>SqlHelper.cs</a></b></td>
				<td><code>❯ This is a class for Implementing All SQL & Database Related Functions </code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication/blob/master/DataAccessLayer/DataAccessLayer.csproj'>DataAccessLayer.csproj</a></b></td>
				<td><code>❯ wtf</code></td>
			</tr>
			</table>
		</blockquote>
	</details>
	<details> <!-- Model Submodule -->
		<summary><b>Model</b></summary>
		<blockquote>
			<table>
			<tr>
				<td><b><a href='https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication/blob/master/Model/UniversityClasses.cs'>UniversityClasses.cs</a></b></td>
				<td><code>❯ This is University Classes Data Model </code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication/blob/master/Model/Result.cs'>Result.cs</a></b></td>
				<td><code>❯ This is a CLass That Helps Exeption Handling</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication/blob/master/Model/Student.cs'>Student.cs</a></b></td>
				<td><code>❯ This is Student Data Model</code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication/blob/master/Model/StudentUniversityClasses.cs'>StudentUniversityClasses.cs</a></b></td>
				<td><code>❯ This is Class Enrollment Data Model </code></td>
			</tr>
			<tr>
				<td><b><a href='https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication/blob/master/Model/Model.csproj'>Model.csproj</a></b></td>
				<td><code>❯ This is The Name of Data Models (Classes) Class Library</code></td>
			</tr>
			</table>
		</blockquote>
	</details>
</details>

---
## 🚀 Getting Started

### ☑️ Prerequisites

Before getting started with AmoozeshyarSampleConsoleApplication, ensure your runtime environment meets the following requirements:

- **Programming Language:** CSharp
- **Package Manager:** Nuget


### ⚙️ Installation

Install AmoozeshyarSampleConsoleApplication using one of the following methods:

**Build from source:**

1. Clone the AmoozeshyarSampleConsoleApplication repository:
```sh
❯ git clone https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication
```

2. Navigate to the project directory:
```sh
❯ cd AmoozeshyarSampleConsoleApplication
```

3. Install the project dependencies:


**Using `nuget`** &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet restore
```




### 🤖 Usage
Run AmoozeshyarSampleConsoleApplication using the following command:
**Using `nuget`** &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet run
```


### 🧪 Testing
Run the test suite using the following command:
**Using `nuget`** &nbsp; [<img align="center" src="https://img.shields.io/badge/C%23-239120.svg?style={badge_style}&logo=c-sharp&logoColor=white" />](https://docs.microsoft.com/en-us/dotnet/csharp/)

```sh
❯ dotnet test
```


---
## 📌 Project Roadmap

- [ ] **`Add Student`**: Enter the student's details to add them to the database.
- [ ] **`Remove Student`**: Provide the student's ID to remove them from the database.
- [ ] **`Add Class`**: Input the class details to create a new class.
- [ ] **`Remove Class`**: Specify the class ID to delete the class from the database.
- [ ] **`Pick a Class for a Student`**: Select a student and assign them to one or more classes.
- [ ] **`Remove Specific Student from Class`**: Choose a class and specify the student to unenroll.
- [ ] **`Show Full Schedule of Classes and Students`**: View the complete schedule with all classes and their enrolled students.
- [ ] **`Exit`**: Close the application.

---


## 🔰 Contributing

- **💬 [Join the Discussions](https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication/discussions)**: Share your insights, provide feedback, or ask questions.
- **🐛 [Report Issues](https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication/issues)**: Submit bugs found or log feature requests for the `AmoozeshyarSampleConsoleApplication` project.
- **💡 [Submit Pull Requests](https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication/blob/main/CONTRIBUTING.md)**: Review open PRs, and submit your own PRs.

<details closed>
<summary>Contributing Guidelines</summary>

1. **Fork the Repository**: Start by forking the project repository to your github account.
2. **Clone Locally**: Clone the forked repository to your local machine using a git client.
   ```sh
   git clone https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication
   ```
3. **Create a New Branch**: Always work on a new branch, giving it a descriptive name.
   ```sh
   git checkout -b new-feature-x
   ```
4. **Make Your Changes**: Develop and test your changes locally.
5. **Commit Your Changes**: Commit with a clear message describing your updates.
   ```sh
   git commit -m 'Implemented new feature x.'
   ```
6. **Push to github**: Push the changes to your forked repository.
   ```sh
   git push origin new-feature-x
   ```
7. **Submit a Pull Request**: Create a PR against the original project repository. Clearly describe the changes and their motivations.
8. **Review**: Once your PR is reviewed and approved, it will be merged into the main branch. Congratulations on your contribution!
</details>

<details closed>
<summary>Contributor Graph</summary>
<br>
<p align="left">
   <a href="https://github.com{/FathiParsa/AmoozeshyarSampleConsoleApplication/}graphs/contributors">
      <img src="https://contrib.rocks/image?repo=FathiParsa/AmoozeshyarSampleConsoleApplication">
   </a>
</p>
</details>

---

## 🎗 License

This project is protected under the [SELECT-A-LICENSE](https://choosealicense.com/licenses) License. For more details, refer to the [LICENSE](https://choosealicense.com/licenses/) file.

---

## 🙌 Acknowledgments

- List any resources, contributors, inspiration, etc. here.

---
