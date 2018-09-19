import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  input1: number;
  input2: number;
  result: number;

  constructor(public navCtrl: NavController, public http: HttpClient) {

  }
  calculate() {
    this.http.get<number>("https://localhost:5001/api/Values/add/" + this.input1 + "/" + this.input2)
      .subscribe(data => {
        this.result = data;
        /* console.log(">>>>>>>"+data); */
      });
  }

}