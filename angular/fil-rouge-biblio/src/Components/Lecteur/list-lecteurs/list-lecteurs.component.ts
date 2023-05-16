import { Component } from '@angular/core';
import { ILecteur } from 'src/Interfaces/ILecteur';
import { LecteurService } from 'src/Services/lecteur.service';

@Component({
  selector: 'app-list-lecteurs',
  templateUrl: './list-lecteurs.component.html',
  styleUrls: ['./list-lecteurs.component.css']
})
export class ListLecteursComponent {

  lecteurs? : ILecteur[];

  constructor(private lecteurService: LecteurService) {
    this.lecteurService.listAll().subscribe(
      (data: ILecteur[]) => {
        this.lecteurs = data;
        console.log(this.lecteurs);
      });
  }
}
