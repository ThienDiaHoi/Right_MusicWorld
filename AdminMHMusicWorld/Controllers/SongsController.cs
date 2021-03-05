﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicWorld.Models;
using MusicWorld.Models.Entities;

namespace AdminMHMusicWorld.Controllers
{
    public class SongsController : Controller
    {
        private readonly MusicDbContext _context;

        public SongsController(MusicDbContext context)
        {
            _context = context;
        }

        // GET: Songs
        public async Task<IActionResult> Index(string keyword)
        {
            if (keyword != null)
            {
                ViewBag.Keyword = keyword;
                var result = await _context.Songs.Where(x => x.Title.Contains(keyword) 
                || x.Artists.Name.Contains(keyword)).ToListAsync();
                return View(result);
            }
            var musicDbContext = _context.Songs.Include(s => s.Albums).Include(s => s.Artists);
            return View(await musicDbContext.ToListAsync());
        }

        // GET: Songs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Songs
                .Include(s => s.Albums)
                .Include(s => s.Artists)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }

        // GET: Songs/Create
        public IActionResult Create()
        {
            ViewData["AlbumsId"] = new SelectList(_context.Albums, "Id", "Title");
            ViewData["ArtistsId"] = new SelectList(_context.Artists, "Id", "Name");
            return View();
        }

        // POST: Songs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Category,Author,UrlImage,UrlMp3,ArtistsId,AlbumsId")] Song song)
        {
            if (ModelState.IsValid)
            {
                _context.Add(song);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlbumsId"] = new SelectList(_context.Albums, "Id", "Title", song.AlbumsId);
            ViewData["ArtistsId"] = new SelectList(_context.Artists, "Id", "Name", song.ArtistsId);
            return View(song);
        }

        // GET: Songs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Songs.FindAsync(id);
            if (song == null)
            {
                return NotFound();
            }
            ViewData["AlbumsId"] = new SelectList(_context.Albums, "Id", "Title", song.AlbumsId);
            ViewData["ArtistsId"] = new SelectList(_context.Artists, "Id", "Name", song.ArtistsId);
            return View(song);
        }

        // POST: Songs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Category,Author,UrlImage,UrlMp3,ArtistsId,AlbumsId")] Song song)
        {
            if (id != song.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(song);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SongExists(song.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlbumsId"] = new SelectList(_context.Albums, "Id", "Title", song.AlbumsId);
            ViewData["ArtistsId"] = new SelectList(_context.Artists, "Id", "Name", song.ArtistsId);
            return View(song);
        }

        // GET: Songs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Songs
                .Include(s => s.Albums)
                .Include(s => s.Artists)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }

        // POST: Songs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var song = await _context.Songs.FindAsync(id);
            _context.Songs.Remove(song);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SongExists(int id)
        {
            return _context.Songs.Any(e => e.Id == id);
        }
    }
}