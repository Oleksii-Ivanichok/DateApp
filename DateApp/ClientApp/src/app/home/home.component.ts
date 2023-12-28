import {Component, Input, OnInit} from '@angular/core';
import {error} from "@angular/compiler-cli/src/transformers/util";
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit{
  ngOnInit(): void {
    this.getUser();
  }

  constructor(private http: HttpClient) {
  }

  registerMode = false;
  users: any;
  registerToggle(){
    this.registerMode = !this.registerMode;
  }

  getUser() {
    this.http.get('https://localhost:7154/api/Users/').subscribe({
      next: response => this.users = response,
      error: error => console.log(error),
      complete: () => console.log('Completed')
    })
  }

  cancelRegisterMode(event:boolean){
    this.registerMode = event;
  }

}
