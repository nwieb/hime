/*******************************************************************************
 * Copyright (c) 2018 Association Cénotélie (cenotelie.fr)
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as
 * published by the Free Software Foundation, either version 3
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General
 * Public License along with this program.
 * If not, see <http://www.gnu.org/licenses/>.
 *
 ******************************************************************************/

package fr.cenotelie.hime.sdk;

/**
 * Represents a Unicode block of characters
 *
 * @author Laurent Wouters
 */
public class UnicodeBlock extends UnicodeSpan {
    /**
     * The block's name
     */
    private final String name;

    /**
     * Get this block's name
     *
     * @return This block's name
     */
    public String getName() {
        return name;
    }

    /**
     * Initializes this block
     *
     * @param name  The block's name
     * @param begin The first (included) character
     * @param end   The last (included) character
     */
    public UnicodeBlock(String name, int begin, int end) {
        super(begin, end);
        this.name = name;
    }
}