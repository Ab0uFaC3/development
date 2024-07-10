import { Component, ViewChild } from '@angular/core';
import { SearchComponent } from '../search/search.component';

@Component({
  selector: 'app-container',
  templateUrl: './container.component.html',
  styleUrl: './container.component.css'
})
export class ContainerComponent {
  name = "Hello World";
  image = "test.jpg"
  notification = false;
  value = '';
  enteredEmailAddress = '';

  @ViewChild(SearchComponent, {static: true}) searchComponent: any;

  courses = [
    {id: 1, name: "Angular", price: 10000, type: "FE"},
    {id: 2, name: "Javascript", price: 50000, type: "FE"},
    {id: 3, name: "React", price: 20000, type: "FE"},
    {id: 4, name: "C#", price: 40000, type: "BE"},
    {id: 5, name: "Python", price: 5000, type: "BE"},
  ]

  changeValue(event: any) {
    this.value = event.target.value;
  }

  onClick(event: any) {
    this.notification = true;
  }

  getType () {
    return this.courses.filter(x => x.type == "BE")[0].id;
  }

  emailAddressEntered(data: string) {
    this.enteredEmailAddress = data;
  }

  data = [31,
    32,
    33,
    34,
    36,
    37,
    38,
    42,
    43,
    45,
    46,
    47,
    48,
    49,
    50,
    51,
    52,
    53,
    54,
    55,
    56,
    57,
    58,
    60,
    62,
    63,
    64,
    65,
    66,
    68,
    69,
    70,
    71,
    72,
    75,
    76,
    77,
    83,
    84,
    85,
    89,
    92,
    94,
    97,
    104]

    getLength() {
      console.log(this.data.length);
    }
    

}
