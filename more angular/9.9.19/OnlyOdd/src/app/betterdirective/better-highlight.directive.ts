import {
  Directive,
  Renderer2,
  ElementRef,
  OnInit,
  HostListener,
  HostBinding,
  Input
} from '@angular/core';

@Directive({
  selector: '[appBetterHighlight]'
})
export class BetterHighlightDirective implements OnInit {

  @Input() defaultColor: string = 'transparent';
  @Input('appBetterHighlight') highlightColor: string = 'blue';
  @HostBinding('style.backgroundColor') backgroundcolor: String;

  constructor(private renderer: Renderer2, private elRef: ElementRef) { }

  ngOnInit() {
    this.backgroundcolor = this.defaultColor;
  }

  @HostListener('mouseenter') mouseover(eventData: Event) {
    this.backgroundcolor = this.highlightColor;
    //this.renderer.setStyle(this.elRef.nativeElement, 'background-color', 'blue');
  }

  @HostListener('mouseleave') mouseleave(eventData: Event) {
    this.backgroundcolor = this.defaultColor;
    //this.renderer.setStyle(this.elRef.nativeElement, 'background-color', 'transparent');
  }
}
