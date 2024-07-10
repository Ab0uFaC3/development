import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContainerComponent } from './container/container.component';
import { FormsModule } from '@angular/forms';
import { SearchComponent } from './search/search.component';
import { StudentListComponent } from './student-list/student-list.component';
import { StudentCountComponent } from './student-count/student-count.component';
import { MyTitlePipe } from './my-title/my-title.pipe';

@NgModule({
  declarations: [
    AppComponent,
    ContainerComponent,
    SearchComponent,
    StudentListComponent,
    StudentCountComponent,
    MyTitlePipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    // for ngModel directive
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
