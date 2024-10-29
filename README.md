<div align="left" style="position: relative;">
<img src="https://iranmoshavere.com/wp-content/uploads/2022/01/azoozeshyar-app.png" align="right" width="30%" style="margin: -20px 0 0 20px;">
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

 
<div class="group relative mb-4 flex items-start md:-ml-12"><svg data-testid="geist-icon" height="16" stroke-linejoin="round" viewBox="0 0 16 16" fill="currentColor" width="16"><path d="M14.9449 6.54871C15.3128 5.45919 15.1861 4.26567 14.5978 3.27464C13.7131 1.75461 11.9345 0.972595 10.1974 1.3406C9.42464 0.481584 8.3144 -0.00692594 7.15045 7.42132e-05C5.37487 -0.00392587 3.79946 1.1241 3.2532 2.79113C2.11256 3.02164 1.12799 3.72615 0.551837 4.72468C-0.339497 6.24071 -0.1363 8.15175 1.05451 9.45178C0.686626 10.5413 0.813308 11.7348 1.40162 12.7258C2.28637 14.2459 4.06498 15.0279 5.80204 14.6599C6.5743 15.5189 7.68504 16.0074 8.849 15.9999C10.6256 16.0044 12.2015 14.8754 12.7478 13.2069C13.8884 12.9764 14.873 12.2718 15.4491 11.2733C16.3394 9.75728 16.1357 7.84774 14.9454 6.54771L14.9449 6.54871ZM8.85001 14.9544C8.13907 14.9554 7.45043 14.7099 6.90468 14.2604C6.92951 14.2474 6.97259 14.2239 7.00046 14.2069L10.2293 12.3668C10.3945 12.2743 10.4959 12.1008 10.4949 11.9133V7.42173L11.8595 8.19925C11.8742 8.20625 11.8838 8.22025 11.8858 8.23625V11.9558C11.8838 13.6099 10.5263 14.9509 8.85001 14.9544ZM2.32133 12.2028C1.9651 11.5958 1.8369 10.8843 1.95902 10.1938C1.98284 10.2078 2.02489 10.2333 2.05479 10.2503L5.28366 12.0903C5.44733 12.1848 5.65003 12.1848 5.81421 12.0903L9.75604 9.84429V11.3993C9.75705 11.4153 9.74945 11.4308 9.73678 11.4408L6.47295 13.3004C5.01915 14.1264 3.1625 13.6354 2.32184 12.2028H2.32133ZM1.47155 5.24819C1.82626 4.64017 2.38619 4.17516 3.05305 3.93366C3.05305 3.96116 3.05152 4.00966 3.05152 4.04366V7.72424C3.05051 7.91124 3.15186 8.08475 3.31654 8.17725L7.25838 10.4228L5.89376 11.2003C5.88008 11.2093 5.86285 11.2108 5.84765 11.2043L2.58331 9.34327C1.13255 8.51426 0.63494 6.68272 1.47104 5.24869L1.47155 5.24819ZM12.6834 7.82274L8.74157 5.57669L10.1062 4.79968C10.1199 4.79068 10.1371 4.78918 10.1523 4.79568L13.4166 6.65522C14.8699 7.48373 15.3681 9.31827 14.5284 10.7523C14.1732 11.3593 13.6138 11.8243 12.9474 12.0663V8.27575C12.9489 8.08875 12.8481 7.91574 12.6839 7.82274H12.6834ZM14.0414 5.8057C14.0176 5.7912 13.9756 5.7662 13.9457 5.7492L10.7168 3.90916C10.5531 3.81466 10.3504 3.81466 10.1863 3.90916L6.24442 6.15521V4.60017C6.2434 4.58417 6.251 4.56867 6.26367 4.55867L9.52751 2.70063C10.9813 1.87311 12.84 2.36563 13.6781 3.80066C14.0323 4.40667 14.1605 5.11618 14.0404 5.8057H14.0414ZM5.50257 8.57726L4.13744 7.79974C4.12275 7.79274 4.11312 7.77874 4.11109 7.76274V4.04316C4.11211 2.38713 5.47368 1.0451 7.15197 1.0461C7.86189 1.0461 8.54902 1.2921 9.09476 1.74011C9.06993 1.75311 9.02737 1.77661 8.99899 1.79361L5.77012 3.63365C5.60493 3.72615 5.50358 3.89916 5.50459 4.08666L5.50257 8.57626V8.57726ZM6.24391 7.00022L7.99972 5.9997L9.75553 6.99972V9.00027L7.99972 10.0003L6.24391 9.00027V7.00022Z" fill="currentColor"></path></svg><div class="ml-4 flex-1 space-y-2 overflow-hidden px-1"><div class="response-speaker" style="float: right; display: none;"><button class="inline-flex items-center justify-center rounded-md text-sm font-medium shadow ring-offset-background transition-colors focus-visible:outline-none focus-visible:ring-2 focus-visible:ring-ring focus-visible:ring-offset-2 disabled:pointer-events-none disabled:opacity-50 border border-input hover:bg-accent hover:text-accent-foreground h-8 px-4 py-2"><svg width="15" height="15" viewBox="0 0 15 15" fill="none" xmlns="http://www.w3.org/2000/svg"><path d="M8 1.5C8 1.31062 7.893 1.13749 7.72361 1.05279C7.55421 0.968093 7.35151 0.986371 7.2 1.1L3.33333 4H1.5C0.671573 4 0 4.67158 0 5.5V9.5C0 10.3284 0.671573 11 1.5 11H3.33333L7.2 13.9C7.35151 14.0136 7.55421 14.0319 7.72361 13.9472C7.893 13.8625 8 13.6894 8 13.5V1.5ZM3.8 4.9L7 2.5V12.5L3.8 10.1C3.71345 10.0351 3.60819 10 3.5 10H1.5C1.22386 10 1 9.77614 1 9.5V5.5C1 5.22386 1.22386 5 1.5 5H3.5C3.60819 5 3.71345 4.96491 3.8 4.9ZM10.833 3.95949C10.7106 3.77557 10.4623 3.72567 10.2784 3.84804C10.0944 3.97041 10.0445 4.21871 10.1669 4.40264C11.4111 6.27268 11.4111 8.72728 10.1669 10.5973C10.0445 10.7813 10.0944 11.0296 10.2784 11.1519C10.4623 11.2743 10.7106 11.2244 10.833 11.0405C12.2558 8.90199 12.2558 6.09798 10.833 3.95949Z" fill="currentColor" fill-rule="evenodd" clip-rule="evenodd"></path></svg></button></div><img class="h-100"><div class="prose break-words dark:prose-invert prose-p:leading-relaxed prose-pre:p-0 fix-max-with-100">
<h3>🤖 Usage</h3>
<p class="mb-2 last:mb-0">After running the application, you'll be presented with a menu of options. Here's how to use each feature:</p>
<ol>
<li>
<p class="mb-2 last:mb-0"><strong>Add Class</strong></p>
<ul>
<li>Select option 1</li>
<li>Enter the name of the new class when prompted</li>
</ul>
</li>
<li>
<p class="mb-2 last:mb-0"><strong>Remove Class</strong></p>
<ul>
<li>Select option 2</li>
<li>Enter the name of the class you want to delete</li>
<li>From the list displayed, enter the exact ID of the class to remove it</li>
</ul>
</li>
<li>
<p class="mb-2 last:mb-0"><strong>Add Student</strong></p>
<ul>
<li>Select option 3</li>
<li>Enter the student's first name, last name, age, and national code as prompted</li>
<li>Ensure the age is between 18 and 120, and the national code is 10 digits</li>
</ul>
</li>
<li>
<p class="mb-2 last:mb-0"><strong>Remove Student</strong></p>
<ul>
<li>Select option 4</li>
<li>Enter the student's first name and last name</li>
<li>From the list displayed, enter the exact ID of the student to remove them</li>
</ul>
</li>
<li>
<p class="mb-2 last:mb-0"><strong>Select Class for Student</strong></p>
<ul>
<li>Select option 5</li>
<li>Enter the student ID</li>
<li>From the list of classes displayed, enter the ID of the class you want to assign to the student</li>
</ul>
</li>
<li>
<p class="mb-2 last:mb-0"><strong>Remove Student from Class</strong></p>
<ul>
<li>Select option 6</li>
<li>From the list of classes displayed, select a class by entering its ID</li>
<li>From the list of students in that class, enter the ID of the student you want to remove</li>
</ul>
</li>
<li>
<p class="mb-2 last:mb-0"><strong>Display Schedule</strong></p>
<ul>
<li>Select option 7 to view the complete schedule of classes and enrolled students</li>
</ul>
</li>
<li>
<p class="mb-2 last:mb-0"><strong>Exit</strong></p>
<ul>
<li>Select option 8 to close the application</li>
</ul>
</li>
</ol>
<p class="mb-2 last:mb-0">Remember to follow the on-screen prompts and enter valid information as requested. The application will guide you through each process and provide feedback on the success or failure of each operation.</p>
<p class="mb-2 last:mb-0">This usage guide provides a step-by-step explanation of how to use each feature of your application, making it easy for users to understand and navigate the system.</p></div><div class="flex items-center justify-end transition-opacity group-hover:opacity-100 md:absolute md:-right-10 md:-top-2 md:opacity-0"></div></div></div>

 ---


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


- **🐛 [Report Issues](https://github.com/FathiParsa/AmoozeshyarSampleConsoleApplication/issues)**: Submit bugs found or log feature requests for the `AmoozeshyarSampleConsoleApplication` project.


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


---

## 🎗 License

This project is protected under the [SELECT-A-LICENSE](https://choosealicense.com/licenses) License. For more details, refer to the [LICENSE](https://choosealicense.com/licenses/) file.

---

## 🙌 Acknowledgments

- Thanks to Microsoft for providing the .NET framework and SQL Server that made this project possible
- Special thanks to the contributors of the Microsoft.Data.SqlClient library for database connectivity
- Appreciation to the open-source community for various code examples and best practices in C# console applications
- Icons8 for providing the education-themed icon used in this project
- Thanks to the contrib.rocks platform for the contributor graph visualization
- Gratitude to all developers who provided feedback and suggestions during the development process
- This acknowledgment section:

1. Recognizes the key technologies and frameworks used
2. Credits the source of visual assets
3. Acknowledges the broader developer community
4. Shows appreciation for any tools or services used in the project.

You can also add or modify this list based on any specific individuals, organizations, or resources that helped you during the development of your Amoozeshyar application.

---
