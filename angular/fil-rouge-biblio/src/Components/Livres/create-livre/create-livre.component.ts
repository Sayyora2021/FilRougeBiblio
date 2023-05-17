import { Component, OnInit } from '@angular/core';
import { ILivre } from 'src/Interfaces/ILivre';
import { IAuteur} from 'src/Interfaces/IAuteur';
import { ITheme } from 'src/Interfaces/ITheme';
import { IMotClef } from 'src/Interfaces/IMotClef';
import { Router } from '@angular/router';
import { LivresService } from 'src/Services/livres.service';
import { AuteurService } from 'src/Services/auteur.service';
import { ThemesService } from 'src/Services/themes.service';
import { MotclefsService } from 'src/Services/motclefs.service';

@Component({
  selector: 'app-create-livre',
  templateUrl: './create-livre.component.html',
  styleUrls: ['./create-livre.component.css']
})
export class CreateLivreComponent implements OnInit {

  auteurs?: IAuteur[];
  themes?: ITheme[];
  tags?: IMotClef[];
  livre: ILivre = { id: 0, titre:'', isbn:'', auteurs: [], exemplaires: [], themes: [], tags:[] }

  constructor(private livresService:LivresService, private auteursService:AuteurService, private themesService:ThemesService, private motclefService:MotclefsService) { }

  create() {
    console.log("livre envoyé:");
    console.log(this.livre)
    this.livresService.create(this.livre);
  }

  ngOnInit(): void {
    this.auteursService.listAll().subscribe(data => { this.auteurs = data; console.log("Auteurs:"); console.log(data) })
    this.themesService.listAll().subscribe(data => { this.themes = data; console.log("Themes:"); console.log(data) })
    this.motclefService.listAll().subscribe(data => { this.tags = data; console.log("Mots clefs:"); console.log(data) })
  
  }

}
