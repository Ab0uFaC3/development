import { Routes } from '@angular/router';
import { StudentComponent } from './student/student.component';
import { StudentDetailsComponent } from './student-details/student-details.component';
import { StudentService } from '../services/student.service';

export const routes: Routes = [
    {
        path: 'student', component: StudentComponent, canActivate: [StudentService]
    },
    {
        path: 'student-details', component: StudentDetailsComponent
    },
    {
        path: '', redirectTo: 'student', pathMatch: 'full'
    }
];
