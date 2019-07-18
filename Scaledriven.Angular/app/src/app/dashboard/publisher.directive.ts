import {Directive, Input, OnInit, TemplateRef, ViewContainerRef} from '@angular/core';

@Directive({
  selector: '[appPublisher]'
})
export class PublisherDirective implements OnInit{

  @Input('appPublisher')
  model: { publish: () => void };

  constructor(
    private templateRef: TemplateRef<object>,
    private viewContainerRef: ViewContainerRef) { }

  ngOnInit(): void {
    this.viewContainerRef.createEmbeddedView(this.templateRef, {
      $implicit: {
          publisher: {
            publish() {
              console.log("publish");
            }
        }
      }
    })

  }
}
