import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-student-count',
  templateUrl: './student-count.component.html',
  styleUrl: './student-count.component.css'
})
export class StudentCountComponent {

  @Input() all: number = 0;
  @Input() male: number = 0;
  @Input() female: number = 0;

  selectedRadioButtonValue: string = 'All';

  @Output()
  changedRadioButtonValue = new EventEmitter<string>();

  onRadioButtonChange() {
    return this.changedRadioButtonValue.emit(this.selectedRadioButtonValue);
  }

}
