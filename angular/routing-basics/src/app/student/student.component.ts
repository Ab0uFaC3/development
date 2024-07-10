import { Component } from '@angular/core';
import { ColorChangeDirective } from '../../directives/color-change.directive';
import { FormControl, ReactiveFormsModule } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [
    RouterLink,
    ColorChangeDirective,
    ReactiveFormsModule
  ],
  templateUrl: './student.component.html',
  styleUrl: './student.component.css'
})
export class StudentComponent {
  name = new FormControl('');

  constructor(private route: Router) {

  }

  navigateToStudentDetails() {
    this.route.navigate(['student-details'])
  }

}
