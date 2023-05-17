import { Component, OnInit } from '@angular/core';
import { ThemesService } from 'src/Services/themes.service';
import { Router, ActivatedRoute } from '@angular/router';
import { ITheme } from 'src/Interfaces/ITheme';

@Component({
  selector: 'app-details-theme',
  templateUrl: './details-theme.component.html',
  styleUrls: ['./details-theme.component.css']
})
export class DetailsThemeComponent implements OnInit {
  theme?:ITheme;

  constructor(private themesService:ThemesService, private router: Router, private route:ActivatedRoute) { }

  ngOnInit(): void {
    let i = this.route.snapshot.paramMap.get('id');
    if(i != null) {
      let id = parseInt(i);
      this.themesService.details(id).subscribe(data => { console.log(data); this.theme = data; })
    }
    
  }

}
