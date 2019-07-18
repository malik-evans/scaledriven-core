import {Directive, Input, OnInit, TemplateRef, ViewContainerRef} from '@angular/core';

export interface NotificationServiceModel {
  getMessages(): string[];
}

@Directive({
  selector: '[notification]'
})
export class NotificationDirective  implements  OnInit {

  @Input('notification')
  model: any;

  constructor(
    private templateRef: TemplateRef<object>,
    private veiwContainerRef: ViewContainerRef) {}

  ngOnInit(): void {

    const service: NotificationServiceModel = {
      getMessages() {
        return ["Mantle is back in action"];
      }
    };

    this.veiwContainerRef.createEmbeddedView(this.templateRef, {
      $implicit: service
    })
  }

}
