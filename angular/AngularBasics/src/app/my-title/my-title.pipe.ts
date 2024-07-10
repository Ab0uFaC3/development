import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'myTitle'
})
export class MyTitlePipe implements PipeTransform {

  transform(firstName: string, ...args: string[]): string {
    if (args[0].toLowerCase() == "male") {
      return "Mr. " + firstName + " " + args[1];
    } else {
      return "Ms. " + firstName + " " + args[1];
    }
  }

}
