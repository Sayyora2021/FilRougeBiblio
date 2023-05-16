import { Component, OnInit } from '@angular/core';
import { ITheme } from 'src/Interfaces/ITheme';
import { ThemesService } from 'src/Services/themes.service';
import { Router } from '@angular/router';
import { ILivre } from 'src/Interfaces/ILivre';

@Component({
  selector: 'app-list-themes',
  templateUrl: './list-themes.component.html',
  styleUrls: ['./list-themes.component.css']
})

export class ListThemesComponent implements OnInit {
  
  themes?: ITheme[];
  nouveauTheme: ITheme = { id: 0, nom:'', description:'', livres: [] };

  constructor(private themesService:ThemesService, private router: Router ) { }

  ngOnInit(): void {
    this.themesService.listAll().subscribe(data => { this.themes = data ; console.log(data) });
  }

  delete(theme:ITheme) {
    this.themesService.delete(theme.id);
    this.themes?.splice(this.themes.indexOf(theme), 1)
  }

  create() {
    this.themesService.create(this.nouveauTheme);
    this.ngOnInit(); this.ngOnInit();
  }

  update(theme:ITheme) {
    console.log(theme);
    this.themesService.update(theme);
  }

  voirLivres(theme:ITheme) {

  }
}
