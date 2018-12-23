import { Component, OnInit } from '@angular/core';
import { Form, FormGroup, FormControl, ReactiveFormsModule } from '@angular/forms';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { useAnimation } from '@angular/animations';
import { Http } from '@angular/http';

@Component({
  selector: 'app-boardnewclient',
  templateUrl: './boardnewclient.component.html',
  styleUrls: ['./boardnewclient.component.css']
})
export class BoardnewclientComponent implements OnInit {

  userForm = new FormGroup({
    memberName: new FormControl('test'),
    phoneNumber: new FormControl('test'),
    emailAddress: new FormControl(''),
    DOB: new FormControl(''),
    appointmentDate: new FormControl(''),
    notes: new FormControl('')
  });

   httpOtions = {
    headers: new HttpHeaders({
      'ContentType': 'application/json'
    })
  }
  constructor(private _http: HttpClient) { }

  ngOnInit() {
  }

  addNewMember() {

    console.log(this.userForm.value);
    this._http.post('https://localhost:44371/api/user/', this.userForm.value, this.httpOtions).subscribe(
      
      
    );


  }


}
