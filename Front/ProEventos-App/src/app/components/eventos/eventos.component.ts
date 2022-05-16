import { Component, OnInit, TemplateRef } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';
import { NgxSpinnerService } from 'ngx-spinner';
import { EventoService } from '../../services/Evento.service';
import { Evento } from '../../models/Evento';

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
