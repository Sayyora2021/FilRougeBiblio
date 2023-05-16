import { Component } from '@angular/core';
import { IAuteur } from 'src/Interfaces/IAuteur';
import { AuteurService } from 'src/Services/auteur.service';

@Component({
  selector: 'app-list-auteurs',
  templateUrl: './list-auteurs.component.html',
  styleUrls: ['./list-auteurs.component.css']
})
export class ListAuteursComponent {

  auteurs? : IAuteur[];

  constructor(private auteurService: AuteurService) {
    this.auteurService.listAll().subscribe(
      (data: IAuteur[]) => {
        this.auteurs = data;
      });
  }

}
