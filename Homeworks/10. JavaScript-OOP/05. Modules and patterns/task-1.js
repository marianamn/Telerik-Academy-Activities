/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
    var Course = {
        init: function (title, presentations) {
            if (!isValidTitle(title)) {
                throw new Error('Invalid course title')
            };

            if(!isPresentationValid(presentations)){
                throw new Error('Invalid presentation name')
            }

            this.title = title;
            this.presentations = presentations;
            this.students = [];
            this.studentID = 1;
            return this;
        },
        addStudent: function (name) {
            var fullName = name.split(' '),
                firstname = fullName[0],
                lastname = fullName[1];

            //validate names
            if (!isNameValid(firstname) || !isNameValid(lastname)) {
                throw new Error('Invalid name')
            }
            if (fullName[2]) {
                throw new Error('Invalid name')
            }

            this.students.push({
                firstname: firstname,
                lastname: lastname,
                id: this.studentID
            });

            return this.studentID++
        },
        getAllStudents: function () {
            return this.students.slice();
        },
        submitHomework: function (studentID, homeworkID) {
            //IDs are invalid
            validIds(studentID, homeworkID, this.students.length, this.presentations.length);

            this.homeworks = [];
            this.homeworks[studentID] = [].push(homeworkID);

            return this;
        },
        pushExamResults: function (results) {
            //invalid ID and score

            this.students.push({
                id: this.studentID,
                score:results
            });

            return this.students;
        },
        getTopStudents: function () {
            var topTenStudents = this.students.slice();

            //sort dessending
            return topTenStudents;
        }
    };

    //validations
    function isValidTitle(str) {
        var valid = true;
    
if (str.length<1
            || /^\s+/.test(str)
            || /\s+$/.test(str)
            || /\s{2,}/g.test(str)) {
            valid = false;
        }
    
        return valid;
    }

    function isPresentationValid(presentation) {
        if (!presentation.length) {
            return false;
        }
        else if (!isValidTitle(presentation)){
            return false;
        }
        else{
            return true;
        }
    }

    function isNameValid(name) {
        var valid = true;

        if (!(/^[A-Z][a-z]*$/.test(name))) {
            valid = false;
        }

        return valid;
    }

    function isIDvalid(id) {
        var valid = true;

        if (id %1 != 0 || id <= 0) {
            valid = false;
        }

        return valid;
    }

    function validIds(studentId, homeworkID, studentsCount, homeworkCount) {
        if (!isIDvalid(studentId) || !isIDvalid(homeworkID)) {
            throw new Error('Invalid ID')
        }

        if (studentId > studentsCount || homeworkID > homeworkCount) {
            throw new Error('Invalid ID')
        }
   
    }

    return Course;
}
module.exports = solve;
