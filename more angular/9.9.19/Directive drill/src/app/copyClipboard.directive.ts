import {Directive, HostListener, ElementRef, Output, EventEmitter} from '@angular/core';

@Directive({
  selector: '[appCopyClipboard]'
})
export class CopyClipboardDirective {

  @Output()
  public textCopied: EventEmitter<string> = new EventEmitter<string>();

    
  constructor(private element: ElementRef) {
  }

  
  @HostListener("click") onClick() {
    console.log(this.element.nativeElement.value);
    const listener = (e: ClipboardEvent) => {
      const clipboard = e.clipboardData || window["clipboardData"];
      clipboard.setData("text", this.element.nativeElement.value.toString());
      e.preventDefault();

      this.textCopied.emit(this.element.nativeElement.value.toString());
    };

    if (this.element.nativeElement.value !== '') {
      document.addEventListener("copy", listener, false)
      document.execCommand("copy");
      document.removeEventListener("copy", listener, false);
    }
  }


}
