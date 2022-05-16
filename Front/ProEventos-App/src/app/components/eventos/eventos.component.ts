import { Component, OnInit  } from '@angular/core';


import { Evento } from '@app/models/Evento';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss'],
  //providers:[EventoService]
})
export class EventosComponent implements OnInit {


  ngOnInit(): void {}
}

function complete(
  arg0: (eventosResp: Evento[]) => void,
  arg1: (error: any) => void,
  complete: any,
  arg3: () => Promise<unknown>
) {
  throw new Error('Function not implemented.');
}
