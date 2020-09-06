# DAT App Questions Module

Before cloning the make sure you have the following installed:
  * [VSCode](https://code.visualstudio.com/)
  * [MongoDB](https://www.mongodb.com/try/download/community)
  * [Git](https://git-scm.com/downloads)
  
Clone the repo
```
git clone github.com/JCelestial/DATApp
```

When opened in VS Code, use `dotnet restore` to install the NuGet packages used, which includes the MongoDB .NET Driver

---
In order for the application to work, the Question Object array must follow the given schema:
```javascript
[
  {
          "questionID" : 102,
          "question" : "Which is the strongest intermolecular force?",
          "answers" : [
                  {
                          "choice" : "A",
                          "details" : "Polar Covalent Bonding"
                  },
                  {
                          "choice" : "B",
                          "details" : "Non-polar Covalent Bonding"
                  },
                  {
                          "choice" : "C",
                          "details" : "Hydrogen Bonding"
                  },
                  {
                          "choice" : "D",
                          "details" : "Dispersion Forces"
                  },
                  {
                          "choice" : "E",
                          "details" : "Ionic Bonding"
                  }
          ],
          "correctAns" : "C",
          "explanation" : "Only hydrogen bonding and dispersion forces are considered intermolecular forces from the answer choices listed. Hydrogen bonding is stronger. Covalent and ionic bonding are intramolecular forces. Ion-dipole and dipole-dipole are also intermolecular forces where an ion-dipole is even stronger than hydrogen bonding.",
          "section" : "Molecules and Fundamentals",
          "subject" : "Biology",
          "isBookmarked" : false,
          "rating" : null,
          "difficulty" : 1
  }
]
```
When all questions are arranged in such a way in a JSON array as such, you can add the array itself into the mongo shell using the following command
```
mongoimport -d <DatabaseName> -c <CollectionName> ./PathToJsonFile --jsonArray
```

---

### Current Tasks to be done
  * Making the question bookmark functionality to allow quick question bookmarking
  * Correct answer tallying
  * Exam submission
  * Difficulty rating
  * Correct answer explanation
    * preferrable to show correct answers after submission