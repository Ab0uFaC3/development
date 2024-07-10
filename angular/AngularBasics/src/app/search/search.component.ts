import { Component, ElementRef, EventEmitter, Input, Output, ViewChild } from '@angular/core';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrl: './search.component.css'
})
export class SearchComponent {
  @Input('idForBE') type = 0;

  @ViewChild('inputVariable') age: any;

  emailValue: string = '';

  isDisabled = false;

  hello = 'colorClass';

  @Output()
  emailValueChange = new EventEmitter<string>();

  getEmailAddress() {
    this.emailValueChange.emit(this.emailValue);
  }

  getAge() {
    console.log(this.age.nativeElement)
  }

  display() {
    console.log("Hello")
  }

}
