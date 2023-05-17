import { Component, OnInit } from '@angular/core';
import { ILecteur } from 'src/Interfaces/ILecteur';
import { LecteurService } from 'src/Services/lecteur.service';

@Component({
  selector: 'app-list-lecteurs',
  templateUrl: './list-lecteurs.component.html',
  styleUrls: ['./list-lecteurs.component.css']
})
export class ListLecteursComponent implements OnInit{

  lecteurs? : ILecteur[];
  nomFiltre: string = '';
  nouveauLecteur: ILecteur = { id: 0, nom: '', prenom:'', listEmprunts: [], email:'', telephone:'', adresse:'', cotisation: false }
  constructor(private lecteurService: LecteurService) {
    
  }
  
  ngOnInit(): void {
    this.lecteurService.listAll().subscribe(
      (data: ILecteur[]) => {
        this.lecteurs = data;
      });
  }

  filtrer() {
    if (this.nomFiltre && this.nomFiltre.trim() !== '') {
      if (this.lecteurs)
        this.lecteurs = this.lecteurs.filter(lecteur =>
          lecteur.nom.toLowerCase().includes(this.nomFiltre.toLowerCase())
        );
    } else {
      this.lecteurs = this.lecteurs;
    }
  }

  delete(lecteur: ILecteur) {
    this.lecteurService.delete(lecteur.id);
    this.lecteurs?.splice(this.lecteurs.indexOf(lecteur), 1);
  }

  update(lecteur: ILecteur) {
    this.lecteurService.update(lecteur);
  }

  create() {
    this.lecteurService.create(this.nouveauLecteur);
    this.ngOnInit(); this.ngOnInit();
  }

}
