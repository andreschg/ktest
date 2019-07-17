import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { StudentsDataService } from './students-data.service';
import { Student } from './Student';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './students.component.html',
  providers: [StudentsDataService]
})
export class StudentsComponent {

  students: Student[];

  constructor(private studentsService: StudentsDataService) {

  }

  ngOnInit() {
    this.studentsService.getStudents()
      .subscribe(students => {
        this.students = students
        console.log(students);
      });  
  }
}
