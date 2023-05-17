import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IEmprunt } from 'src/Interfaces/IEmprunt';
import { IExemplaire } from 'src/Interfaces/IExemplaire';
import { ILecteur } from 'src/Interfaces/ILecteur';
import { EmpruntService } from 'src/Services/emprunt.service';
import { ExemplaireService } from 'src/Services/exemplaire.service';
import { LecteurService } from 'src/Services/lecteur.service';

@Component({
  selector: 'app-create-emprunts',
  templateUrl: './create-emprunts.component.html',
  styleUrls: ['./create-emprunts.component.css']
})
export class CreateEmpruntsComponent implements OnInit {

  emprunt: IEmprunt = {} as IEmprunt;
  lecteurs: ILecteur[] = [];
  exemplaires: IExemplaire[] = [];

  constructor(private empruntService: EmpruntService, private router: Router, private exemplaireService: ExemplaireService, private lecteurService: LecteurService) {
  }
  ngOnInit(): void {

    this.lecteurService.listAll().subscribe(
      (data: ILecteur[]) => {
        this.lecteurs = data;
      });

    this.exemplaireService.listAll().subscribe(
      (data: IExemplaire[]) => {
        this.exemplaires = data;
      });

    this.filtrerExemplaire();

  }

  create() {
    this.empruntService.create(this.emprunt);
    this.router.navigate(['/Emprunts']);
  }

  filtrerExemplaire() {

    let emprunts: IEmprunt[];
  this.empruntService.listAll().subscribe((data: IEmprunt[]) => {
    emprunts = data.filter(e => e.dateRetourReel == null);
    this.exemplaires = this.exemplaires.filter(exemplaire => {
      return !emprunts.some(emprunt => emprunt.exemplaire.id === exemplaire.id);
    });
  });

  }
  

}
