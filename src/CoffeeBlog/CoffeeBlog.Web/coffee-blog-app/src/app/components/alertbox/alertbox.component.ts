import { Component, OnInit, Input } from '@angular/core';
import { Message } from 'src/app/models/message.model';

@Component({
  selector: 'app-alertbox',
  templateUrl: './alertbox.component.html'
})
export class AlertboxComponent implements OnInit {
  @Input() messages: Array<Message>;
  alertClass: string;
  constructor() { }

  ngOnInit(): void {
    this.alertClass = 'alert alert-danger';
  }

}
