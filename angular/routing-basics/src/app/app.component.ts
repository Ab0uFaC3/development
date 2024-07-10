import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { StudentService } from '../services/student.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    RouterLink
  ],
  providers: [
    StudentService
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'routing-basics';

  private _studentService: StudentService;
  students: any;

  constructor(private studentService: StudentService) {
    this._studentService = studentService;
  }

  ngOnInit() {
    this.students = this._studentService.getStudents();
  }

}
