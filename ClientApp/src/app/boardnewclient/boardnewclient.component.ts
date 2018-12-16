import { Component, OnInit } from '@angular/core';
import { Form } from '@angular/forms';

@Component({
  selector: 'app-boardnewclient',
  templateUrl: './boardnewclient.component.html',
  styleUrls: ['./boardnewclient.component.css']
})
export class BoardnewclientComponent implements OnInit {

  userForm: Form;
  constructor() { }

  ngOnInit() {
  }


}
