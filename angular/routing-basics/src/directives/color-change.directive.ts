import { Directive, ElementRef, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appColorChange]',
  standalone: true
})
export class ColorChangeDirective {

  constructor(private element: ElementRef, private renderer: Renderer2) {
    this.element = element;
    this.renderer = renderer;
  }

  ngOnInit() {
    this.renderer.setStyle(this.element.nativeElement, 'backgroundColor', "yellow");
  }

}
